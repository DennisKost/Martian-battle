using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;

namespace Martian_Battle
{
    class Controller //Основной управляющий игрой класс
    {
        int m_points; //количество заработанных очков
        int m_pointsUp; //количество прибавляемых очков
        int m_count; //переменная, определяющая единицы продвижения кораблей
        double complexity; //сложность игры
        Ship m_ship = new Ship(); //ссылка на класс, описывающий корабль
        Shot m_shot = new Shot(); //ссылка на класс, описывающий выстрел
        Platform m_platform = new Platform(); //ссылка на класс, описывающий платформу
        List<TextBox> m_deactivateShips = new List<TextBox>(); //список неактивных кораблей
        List<TextBox> m_activateShips = new List<TextBox>(); //список активных кораблей
        List<TableLayoutPanel> m_shots = new List<TableLayoutPanel>(); //список всех активных выстрелов
        GameForm m_sourceForm; //ссылка на главную форму
        ProgressBar m_sourceProgressBar; //ссылка на количество жизней
        TableLayoutPanel m_platformTableLayoutPanel; //ссылка на платформу
        MediaPlayer m_shotSound; //ссылка на звук выстрела
        MediaPlayer m_killSound; //ссылка на звук уничтожения корабля
        DateTime m_shipMoveTime; //время продвижения кораблей
        DateTime m_ComplexityTime; //время изменения сложности
        bool m_shotLock; //блокировка выстрела
        bool m_startShot; //переменная, задающая разрешение на выстрел
        bool m_shotOff; //переменная, которая показывает, был ли поражен корабль выстрелом
        bool m_playGame = false; //переменная, показывающая текущее состояние игры, предназначена для блокировки случайных выстрелов
        public Controller(GameForm sourceForm, ProgressBar sourceProgressBar, TableLayoutPanel platform, TextBox[] ships)
        {
            //Инициализация основных полей для игры
            (m_shotSound = new MediaPlayer()).Open(new Uri("fly.wav", UriKind.Relative));
            (m_killSound = new MediaPlayer()).Open(new Uri("kill.wav", UriKind.Relative));
            m_sourceForm = sourceForm;
            m_sourceProgressBar = sourceProgressBar;
            m_platformTableLayoutPanel = platform;
            m_deactivateShips.Add(m_ship.GenerateAmphibiousShip(ships[0]));
            m_deactivateShips.Add(m_ship.GenerateAmphibiousShip(ships[1]));
            m_deactivateShips.Add(m_ship.GenerateAssaultShip(ships[2]));
            m_deactivateShips.Add(m_ship.GenerateAssaultShip(ships[3]));
            m_deactivateShips.Add(m_ship.GenerateBomberShip(ships[4]));
            m_deactivateShips.Add(m_ship.GenerateBomberShip(ships[5]));
            m_sourceForm.Click += ShotUp;
        }
        public void StartGame() //Запуск игры
        {
            //инициализация переменных для начала игры
            m_count = 1;
            complexity = 50;
            m_points = 0;
            m_pointsUp = 1;
            m_startShot = false;
            m_shotLock = true;
            m_shotOff = false;
            m_shipMoveTime = DateTime.Now;
            m_ComplexityTime = DateTime.Now;
            GenerateShip(); //генерация первого корабля в форме
            m_playGame = true; //установка переменной для возможности выстрелов
            while (OneCycleGame()) { } //Основной бесконечный цикл игры
            GameOver(); //вызов метода завершения игры
        }
        bool OneCycleGame() //Один такт игры
        {
            m_platform.UpdatePlatformLocation(m_sourceForm, m_platformTableLayoutPanel); //обновление положения платформы
            UpAllShots();
            if (m_shot.IsShotUp(m_sourceForm)) //вход при движении мыши ниже платформы
            {
                ShotUp(m_sourceForm, EventArgs.Empty);
            }
            if (!DownAllShips())
            {
                return false;
            }
            if (m_count % 120 == 0) //запуск очередного корабля
            {
                if (m_deactivateShips.Count == 0)
                {
                    throw new IndexOutOfRangeException();
                }
                GenerateShip();
                m_count = 1;
                if (!m_shotLock)
                {
                    m_startShot = true;
                }
            }
            else if (m_count % 60 == 0 && !m_shotLock) //снятие блокировки для запуска выстрела после достижения кратности 60 пунктам продвижения кораблей
            {
                m_startShot = true;
            }
            if ((DateTime.Now - m_ComplexityTime).Seconds >= 10) //повышение сложности каждые 10 секунд
            {
                complexity *= 0.9;
                m_pointsUp++;
                m_ComplexityTime = DateTime.Now;
            }
            return true;
        }
        bool DownAllShips()
        {
            if ((DateTime.Now - m_shipMoveTime).Milliseconds >= complexity) //продвижение кораблей вниз через время, заданное сложностью
            {
                for (int k = 0; k < m_activateShips.Count; k++)
                {
                    m_ship.UpdateShipLocation(m_activateShips[k]); //обновление положения корабля
                    if (m_ship.Vertical(m_activateShips[k]) > 480)
                    {
                        if (m_sourceProgressBar.Value - m_ship.Below(m_activateShips[k]) <= 0) //проверка условия выхода из игры
                        {
                            m_sourceProgressBar.Value = 0;
                            return false;
                        }
                        m_sourceProgressBar.Value -= m_ship.Below(m_activateShips[k]);
                        DeleteShip(m_activateShips[k--]);//удаление корабля по заданному индексу
                    }
                }
                m_shipMoveTime = DateTime.Now;
                m_shotLock = false;
                m_count++;
            }
            return true;
        }
        void UpAllShots()
        {
            for (int k = 0; k < m_shots.Count; k++) //продвижение всех выстрелов вверх
            {
                m_shot.UpdateShotLocation(m_shots[k]); //обновление положения конкретного выстрела
                for (int m = 0; m < m_activateShips.Count; m++)
                {
                    if (m_ship.IsKillShip(m_activateShips[m], m_shots[k])) //вход при уничтожении корабля
                    {
                        m_killSound.Stop();
                        m_shotSound.Stop();
                        m_killSound.Play();
                        m_points += m_pointsUp;
                        DeleteShot(m_shots[k--]);
                        DeleteShip(m_activateShips[m]);
                        m_shotOff = true;
                        break;
                    }
                }
                if (!m_shotOff && m_shot.Vertical(m_shots[k]) <= 0)
                {
                    DeleteShot(m_shots[k--]);
                }
                m_shotOff = false;
            }
        }
        void GenerateShip() //добавление корабля в список активных кораблей
        {
            m_activateShips.Add(m_deactivateShips[m_ship.m_shipsRandom.Next(m_deactivateShips.Count - 1)]);
            m_deactivateShips.Remove(m_activateShips[m_activateShips.Count - 1]);
            m_ship.ReEdit(m_activateShips[m_activateShips.Count - 1]);
        }
        void DeleteShot(TableLayoutPanel shot) //выгрузка выстрела
        {
            shot.Dispose();
            m_shots.Remove(shot);
        }
        void DeleteShip(TextBox ship) //удаление корабля
        {
            ship.Hide();
            m_deactivateShips.Add(ship);
            m_activateShips.Remove(ship);
        }
        private void ShotUp(object sender, EventArgs e) //Метод выстрела по нажатию ЛКМ или наведении ниже платформы
        {
            if (m_playGame && m_startShot && !m_shotLock)
            {
                m_shotSound.Stop();
                m_shotSound.Play();
                var shotPanel = m_shot.GenerateShot(m_platformTableLayoutPanel);
                m_shots.Add(shotPanel);
                m_sourceForm.AddShotToForm(shotPanel);
                m_startShot = false;
                m_shotLock = true;
            }
        }
        void GameOver() //очиства списков кораблей
        {
            m_playGame = false;
            for (int i = 0; m_activateShips.Count != 0;) //удаление всех кораблей
            {
                m_deactivateShips.Add(m_activateShips[i]);
                m_activateShips[i].Hide();
                m_activateShips.RemoveAt(i);
            }
            for (int i = 0; m_shots.Count != 0;) //удаление всех выстрелов
            {
                m_shots[i].Dispose();
                m_shots.RemoveAt(i);
            }
            m_sourceForm.GameOver(m_points); //отображение необходимых элементов при завершении игры
        }
    }
}
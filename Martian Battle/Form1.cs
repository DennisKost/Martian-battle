using System;
using System.Windows.Forms;
using System.Media;

namespace Martian_Battle
{
    public partial class GameForm : Form //основная форма приложения
    {
        SoundPlayer m_gameMusic = new SoundPlayer("game.wav"); //ссылки на игровую музыку
        SoundPlayer m_endMusic = new SoundPlayer("end.wav"); //ссылки на постигровую музыку
        Controller m_controlGame; //ссылка на управляющий объект
        public GameForm()
        {
            InitializeComponent();
            m_gameMusic.PlayLooping(); //запуск игровой музыки
        }
        private void StartGameButtonHandler(object sender, EventArgs e) //кнопка для начала игры
        {
            //скрытие всех начальных элементов формы
            StartGameButton.Hide();
            Ship1.Hide();
            Ship2.Hide();
            Ship3.Hide();
            Ship4.Hide();
            Ship5.Hide();
            Ship6.Hide();
            MartianBattleLabel.Hide();
            //определение управляющего объекта
            m_controlGame = new Controller(this, NumbersOfLives, Platform, new TextBox[] { Ship1, Ship2, Ship3, Ship4, Ship5, Ship6 });
            m_controlGame.StartGame(); //запуск игры
        }
        private void RetryButtonHandler(object sender, EventArgs e) //кнопка повторного запуска игры
        {
            //скрытие всех лишних элементов формы
            GameOverLabel.Hide();
            RetryButton.Hide();
            ExitButton.Hide();
            MartianBattleLabel.Hide();
            PointsLabel.Hide();
            NumbersOfLives.Value = 100;
            m_endMusic.Stop();
            m_gameMusic.PlayLooping();
            m_controlGame.StartGame(); //повторный запуск игры
        }
        private void CloseButtonHandler(object sender, EventArgs e) //кнопка выхода из игрового приложения
        {
            Close(); //закрытие приложения
        }
        public void AddShotToForm(TableLayoutPanel shot) //добавление выстрела в форму
        {
            Controls.Add(shot);
        }
        public void GameOver(int points) //вывод результатов игры
        {
            m_gameMusic.Stop();
            m_endMusic.PlayLooping();
            GameOverLabel.Show();
            RetryButton.Show();
            ExitButton.Show();
            MartianBattleLabel.Show();
            PointsLabel.Text = "POINTS: " + points.ToString();
            PointsLabel.Show();
        }
    }
}
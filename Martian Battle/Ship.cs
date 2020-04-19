using System;
using System.Drawing;
using System.Windows.Forms;

namespace Martian_Battle
{
    class Ship //описание кораблей
    {
        public Random m_shipsRandom = new Random(); //рандомайзер положения корабля
        public int Below(TextBox ship) //количество наносимого урона
        {
            switch (ship.Text)
            {
                case "AmphibiousShip":
                    {
                        return 1;
                    }
                case "BomberShip":
                    {
                        return 10;
                    }
                case "AssaultShip":
                    {
                        return 5;
                    }
            }
            return 0;
        }
        public void ReEdit(TextBox ship)
        {
            ship.Location = new Point(m_shipsRandom.Next(720), 0);
            ship.Show();
        }
        public TextBox GenerateAmphibiousShip(TextBox ship)
        {
            ship.Hide();
            ship.Size = new Size(60, 10);
            ship.BackColor = Color.Blue;
            ship.Text = "AmphibiousShip";
            return ship;
        }
        public TextBox GenerateBomberShip(TextBox ship)
        {
            ship.Hide();
            ship.Size = new Size(60, 10);
            ship.BackColor = Color.Red;
            ship.Text = "BomberShip";
            return ship;
        }
        public TextBox GenerateAssaultShip(TextBox ship)
        {
            ship.Hide();
            ship.Size = new Size(60, 10);
            ship.BackColor = Color.Green;
            ship.Text = "AssaultShip";
            return ship;
        }
        public void UpdateShipLocation(TextBox ship) 
        {
            ship.Location = new Point(ship.Location.X, ship.Location.Y + 1);
        }
        public bool IsKillShip(TextBox ship, TableLayoutPanel shot) //проверка условия уничтожения корабля
        {
            if (shot.Location.X + 10 >= ship.Location.X && shot.Location.X <= ship.Location.X + 60 &&
        shot.Location.Y <= ship.Location.Y + 10 && shot.Location.Y >= ship.Location.Y)
            {
                return true;
            }
            return false;
        }
        public int Vertical(TextBox ship)
        {
            return ship.Location.Y;
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace CP
{
    class Shot
    {
        public bool IsShotUp(Form sourceForm)
        {
            if (Cursor.Position.X - sourceForm.Location.X > 0 && Cursor.Position.X - sourceForm.Location.X < sourceForm.Size.Width &&
                Cursor.Position.Y - sourceForm.Location.Y > 540)
            {
                return true;
            }
            return false;
        }
        public void UpdateShotLocation(TableLayoutPanel updateShot) //изменение положения выстрела вверх на 1 пункт
        {
            updateShot.Location = new Point(updateShot.Location.X, updateShot.Location.Y - 1);
        }
        public TableLayoutPanel GenerateShot(TableLayoutPanel platform)
        {
            var shotPanel = new TableLayoutPanel();
            shotPanel.Location = new Point(platform.Location.X + 96, platform.Location.Y - 10);
            shotPanel.Size = new Size(10, 10);
            shotPanel.BackColor = Color.Red;
            return shotPanel;
        }
        public int Vertical(TableLayoutPanel shot)
        {
            return shot.Location.Y;
        }
    }
}

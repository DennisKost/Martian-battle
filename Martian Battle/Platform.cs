using System.Drawing;
using System.Windows.Forms;

namespace Martian_Battle
{
    class Platform
    {
        public void UpdatePlatformLocation(Form sourceForm, TableLayoutPanel platform) //изменение положения платформы в зависимости от положения мыши по горизонтали
        {
            platform.Location = new Point(Cursor.Position.X - sourceForm.Location.X - 108, platform.Location.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game_winform.Classes
{
    class Collision
    {
        public static bool Coll(PictureBox obj1, PictureBox obj2)
        {
            if(
                 obj1.Location.X >= obj2.Location.X - obj2.Size.Width + 5
                 &&
                 obj1.Location.X <= obj2.Location.X + obj2.Size.Width - 5
                 &&
                 obj1.Location.Y >= obj2.Location.Y - obj2.Size.Height + 5
                 &&
                 obj1.Location.Y <= obj2.Location.Y + obj2.Size.Height - 5
                 )
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

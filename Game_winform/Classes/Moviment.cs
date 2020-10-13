using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game_winform.Classes
{
    class Moviment
    {
        public void Left(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X - speed, obj.Location.Y);
        }

        public void Right(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X + speed, obj.Location.Y);
        }

        public void Up(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X, obj.Location.Y - speed);
        }

        public void Down(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X, obj.Location.Y + speed);
        }

       
    }
}

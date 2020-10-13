using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_winform.Classes
{
    class Inimigo
    {
        public void Movimentar(PictureBox person, string direcao, int velocidade)
        {
            if(direcao == "rigth")
            {
                person.Location = new Point(person.Location.X + velocidade, person.Location.Y);
            }

            if(direcao == "left")
            {
                person.Location = new Point(person.Location.X - velocidade, person.Location.Y);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_winform
{
    public partial class Enemy : Form
    {
        public int speed = 15;

        public Enemy()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y - speed);
            }

            if(e.KeyCode == Keys.Down)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y + speed);
            }

            if(e.KeyCode == Keys.Right)
            {
                Player.Location = new Point(Player.Location.X + speed, Player.Location.Y);
            }

            if(e.KeyCode == Keys.Left)
            {
                Player.Location = new Point(Player.Location.X - speed, Player.Location.Y);
            }

            if(e.KeyCode == Keys.W)
            {
               
                Player.Location = new Point(Player.Location.X, Player.Location.Y - 100);
                Player.Location = new Point(Player.Location.X, Player.Location.Y + 100);
            }

        }

        private void tb_velocidade_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randX = new Random();
            Random randY = new Random();

            int valorY = randY.Next(100, 500);
            int valorX = randX.Next(100, 500);

            //Inimigo.Location = new Point(Inimigo.Location.X + valorX, Inimigo.Location.Y + valorY);
            Inimigo.Visible = true;
            timer2.Enabled = true;
        }

        private void Enemy_Load(object sender, EventArgs e)
        {
            Inimigo.Visible = false;
            timer1.Enabled = true;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Inimigo.Visible = false;
            timer1.Enabled = true;
        }
    }
}

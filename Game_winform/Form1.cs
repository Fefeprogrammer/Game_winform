using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_winform.Classes;

namespace Game_winform
{
    public partial class Enemy : Form
    {
        public int speed = 15;
        public int speedEnemy = 10;
        Moviment moviment = new Moviment();
        Collision colid = new Collision();

        public Enemy()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                moviment.Up(Player, speed);
            }

            if(e.KeyCode == Keys.Down)
            {
                moviment.Down(Player, speed);
            }

            if(e.KeyCode == Keys.Right)
            {
                moviment.Right(Player, speed);
            }

            if(e.KeyCode == Keys.Left)
            {
                moviment.Left(Player, speed);
            }

            if(e.KeyCode == Keys.C)
            {
                Shoot.Visible = true;
                timer2.Enabled = true;
            }

            if(Shoot.Location.Y == limite_top.Location.Y)
            {
                Shoot.Location = new Point(Shoot.Location.X, Shoot.Location.Y - 0);
            }

        }

        private void tb_velocidade_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Inimigo.Visible = true;
            moviment.Right(Inimigo, speedEnemy);

            if(Inimigo.Location.X >= 600)
            {
                moviment.Left(Inimigo, speedEnemy);
            }

            if(Inimigo.Location.X <= 0)
            {
                moviment.Right(Inimigo, speedEnemy);
            }

            /*if(Collision.Coll(Inimigo, limite_right) == true)
            {
                moviment.Left(Inimigo, speedEnemy);
                MessageBox.Show("Colidiu");
            }*/
        }

        private void Enemy_Load(object sender, EventArgs e)
        {
            Inimigo.Visible = false;
            timer1.Enabled = true;
            Shoot.Location = Player.Location;
            Shoot.Visible = false;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Shoot.Location = new Point(Shoot.Location.X, Shoot.Location.Y - speed);
            
          
        }

        private void PositionShoot()
        {
            Shoot.Location = Player.Location;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PositionShoot();
        }

       

        
    }
}

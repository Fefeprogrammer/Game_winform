namespace Game_winform
{
    partial class Enemy
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Inimigo = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::Game_winform.Properties.Resources.Ground;
            this.Ground.Location = new System.Drawing.Point(-4, 425);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(803, 47);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // Inimigo
            // 
            this.Inimigo.Image = global::Game_winform.Properties.Resources.Enemy;
            this.Inimigo.Location = new System.Drawing.Point(114, 55);
            this.Inimigo.Name = "Inimigo";
            this.Inimigo.Size = new System.Drawing.Size(100, 50);
            this.Inimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Inimigo.TabIndex = 1;
            this.Inimigo.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Game_winform.Properties.Resources.Player;
            this.Player.Location = new System.Drawing.Point(331, 294);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(129, 93);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Enemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Inimigo);
            this.Controls.Add(this.Player);
            this.Name = "Enemy";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Enemy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Inimigo;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}


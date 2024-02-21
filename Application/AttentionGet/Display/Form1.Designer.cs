namespace AttentionGet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ground = new System.Windows.Forms.PictureBox();
            this.CactusSimple = new System.Windows.Forms.PictureBox();
            this.CactusDouble = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.gameOver = new System.Windows.Forms.Label();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CactusSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CactusDouble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Black;
            this.Ground.Location = new System.Drawing.Point(-9, 391);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(820, 67);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // CactusSimple
            // 
            this.CactusSimple.Image = ((System.Drawing.Image)(resources.GetObject("CactusSimple.Image")));
            this.CactusSimple.Location = new System.Drawing.Point(504, 345);
            this.CactusSimple.Name = "CactusSimple";
            this.CactusSimple.Size = new System.Drawing.Size(23, 46);
            this.CactusSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CactusSimple.TabIndex = 2;
            this.CactusSimple.TabStop = false;
            this.CactusSimple.Tag = "obstacle";
            // 
            // CactusDouble
            // 
            this.CactusDouble.Image = ((System.Drawing.Image)(resources.GetObject("CactusDouble.Image")));
            this.CactusDouble.Location = new System.Drawing.Point(643, 358);
            this.CactusDouble.Name = "CactusDouble";
            this.CactusDouble.Size = new System.Drawing.Size(32, 33);
            this.CactusDouble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CactusDouble.TabIndex = 3;
            this.CactusDouble.TabStop = false;
            this.CactusDouble.Tag = "obstacle";
            // 
            // Dino
            // 
            this.Dino.Image = ((System.Drawing.Image)(resources.GetObject("Dino.Image")));
            this.Dino.Location = new System.Drawing.Point(86, 348);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(40, 43);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dino.TabIndex = 1;
            this.Dino.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(105, 31);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(318, 152);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(171, 31);
            this.gameOver.TabIndex = 5;
            this.gameOver.Text = "Game Over !!!";
            this.gameOver.Visible = false;
            // 
            // buttonReplay
            // 
            this.buttonReplay.Enabled = false;
            this.buttonReplay.Location = new System.Drawing.Point(343, 195);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(98, 25);
            this.buttonReplay.TabIndex = 6;
            this.buttonReplay.Text = "Replay";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Visible = false;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Enabled = false;
            this.buttonLeave.Location = new System.Drawing.Point(343, 226);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(98, 25);
            this.buttonLeave.TabIndex = 6;
            this.buttonLeave.Text = "Exit";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.CactusSimple);
            this.Controls.Add(this.CactusDouble);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "T-Rex Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CactusSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CactusDouble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox CactusSimple;
        private System.Windows.Forms.PictureBox CactusDouble;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTime;
        public System.Windows.Forms.Label gameOver;
        public System.Windows.Forms.Button buttonReplay;
        public System.Windows.Forms.Button buttonLeave;
    }
}


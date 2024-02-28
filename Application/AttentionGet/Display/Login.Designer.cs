namespace AttentionGet.Display
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Background = new System.Windows.Forms.PictureBox();
            this.titel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pseudoEnter = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(16, 188);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(772, 250);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.titel.Location = new System.Drawing.Point(328, 93);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(141, 31);
            this.titel.TabIndex = 2;
            this.titel.Text = "Dino Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Before playing, please choose a nickname :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pseudoEnter
            // 
            this.pseudoEnter.Location = new System.Drawing.Point(334, 188);
            this.pseudoEnter.Name = "pseudoEnter";
            this.pseudoEnter.Size = new System.Drawing.Size(123, 20);
            this.pseudoEnter.TabIndex = 4;
            this.pseudoEnter.TextChanged += new System.EventHandler(this.pseudoEnter_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(346, 227);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(98, 25);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.pseudoEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.Background);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pseudoEnter;
        private System.Windows.Forms.Button confirm;
    }
}
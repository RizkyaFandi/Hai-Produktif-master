namespace LoginCobaCoba
{
    partial class VerifEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifEmail));
            this.login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.garis1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.roundButton1 = new LoginCobaCoba.RoundButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.garis2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.login.Location = new System.Drawing.Point(572, 41);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(166, 78);
            this.login.TabIndex = 3;
            this.login.Text = "Verifikasi\r\nEmail\r\n";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(400, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 19);
            this.textBox1.TabIndex = 12;
            this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // garis1
            // 
            this.garis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.garis1.Location = new System.Drawing.Point(400, 233);
            this.garis1.Name = "garis1";
            this.garis1.Size = new System.Drawing.Size(338, 2);
            this.garis1.TabIndex = 11;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.username.Location = new System.Drawing.Point(397, 178);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(81, 17);
            this.username.TabIndex = 10;
            this.username.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(401, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 27);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.title2);
            this.panel1.Controls.Add(this.title1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 513);
            this.panel1.TabIndex = 14;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(110, 212);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(117, 40);
            this.title2.TabIndex = 3;
            this.title2.Text = "ayo produktif\r\nhari ini\r\n";
            this.title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(100, 139);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(168, 76);
            this.title1.TabIndex = 2;
            this.title1.Text = "HAI!";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.roundButton1.Location = new System.Drawing.Point(675, 401);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(63, 63);
            this.roundButton1.TabIndex = 13;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(401, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 19);
            this.textBox2.TabIndex = 64;
            this.textBox2.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // garis2
            // 
            this.garis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.garis2.Location = new System.Drawing.Point(401, 318);
            this.garis2.Name = "garis2";
            this.garis2.Size = new System.Drawing.Size(338, 2);
            this.garis2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(398, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "E-mail";
            // 
            // VerifEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.garis2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.garis1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerifEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hai! Produktif | Lupa Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel garis1;
        private System.Windows.Forms.Label username;
        private RoundButton roundButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel garis2;
        private System.Windows.Forms.Label label1;
    }
}
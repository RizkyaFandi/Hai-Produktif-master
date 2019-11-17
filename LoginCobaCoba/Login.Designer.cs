namespace LoginCobaCoba
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.garis1 = new System.Windows.Forms.Panel();
            this.garis2 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.Label();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Label();
            this.lupapass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton1 = new LoginCobaCoba.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.title2);
            this.panel1.Controls.Add(this.title1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 530);
            this.panel1.TabIndex = 0;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(110, 212);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(117, 40);
            this.title2.TabIndex = 1;
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
            this.title1.TabIndex = 0;
            this.title1.Text = "HAI!";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.username.Location = new System.Drawing.Point(400, 169);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(81, 17);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // garis1
            // 
            this.garis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.garis1.Location = new System.Drawing.Point(403, 224);
            this.garis1.Name = "garis1";
            this.garis1.Size = new System.Drawing.Size(338, 2);
            this.garis1.TabIndex = 6;
            // 
            // garis2
            // 
            this.garis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.garis2.Location = new System.Drawing.Point(403, 297);
            this.garis2.Name = "garis2";
            this.garis2.Size = new System.Drawing.Size(338, 2);
            this.garis2.TabIndex = 8;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.password.Location = new System.Drawing.Point(400, 242);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 17);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            // 
            // unameBox
            // 
            this.unameBox.BackColor = System.Drawing.Color.White;
            this.unameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameBox.Location = new System.Drawing.Point(403, 196);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(337, 19);
            this.unameBox.TabIndex = 9;
            this.unameBox.Enter += new System.EventHandler(this.UnameBox_Enter);
            this.unameBox.Leave += new System.EventHandler(this.UnameBox_Leave);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(403, 269);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(337, 19);
            this.passBox.TabIndex = 10;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.passBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.close.Location = new System.Drawing.Point(745, 0);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(15);
            this.close.Size = new System.Drawing.Size(55, 59);
            this.close.TabIndex = 11;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.label1_Click_1);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // lupapass
            // 
            this.lupapass.AutoSize = true;
            this.lupapass.BackColor = System.Drawing.Color.Transparent;
            this.lupapass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lupapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lupapass.ForeColor = System.Drawing.Color.Gray;
            this.lupapass.Location = new System.Drawing.Point(400, 351);
            this.lupapass.Name = "lupapass";
            this.lupapass.Size = new System.Drawing.Size(99, 13);
            this.lupapass.TabIndex = 12;
            this.lupapass.Text = "Lupa password?";
            this.lupapass.Click += new System.EventHandler(this.Lupapass_Click);
            this.lupapass.MouseLeave += new System.EventHandler(this.lupapass_MouseLeave);
            this.lupapass.MouseHover += new System.EventHandler(this.lupapass_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(400, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.roundButton1.Location = new System.Drawing.Point(677, 348);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(63, 63);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            this.roundButton1.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            this.roundButton1.MouseHover += new System.EventHandler(this.roundButton1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.label2.Location = new System.Drawing.Point(636, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lupapass);
            this.Controls.Add(this.close);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.unameBox);
            this.Controls.Add(this.garis2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.garis1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hai! Produktif";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label username;
        private RoundButton roundButton1;
        private System.Windows.Forms.Panel garis1;
        private System.Windows.Forms.Panel garis2;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox unameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lupapass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


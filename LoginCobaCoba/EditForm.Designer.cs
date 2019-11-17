namespace LoginCobaCoba
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.rbSelesai = new System.Windows.Forms.RadioButton();
            this.rbBelumSelesai = new System.Windows.Forms.RadioButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 50);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Edit";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(487, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEdit.Location = new System.Drawing.Point(108, 300);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(321, 42);
            this.btnEdit.TabIndex = 97;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Keaktifan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(96, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(97, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(107, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 105;
            this.label9.Text = ":";
            // 
            // tbNotes
            // 
            this.tbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbNotes.Location = new System.Drawing.Point(115, 11);
            this.tbNotes.MaxLength = 40;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(305, 20);
            this.tbNotes.TabIndex = 108;
            // 
            // rbSelesai
            // 
            this.rbSelesai.AutoSize = true;
            this.rbSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbSelesai.Location = new System.Drawing.Point(124, 257);
            this.rbSelesai.Name = "rbSelesai";
            this.rbSelesai.Size = new System.Drawing.Size(79, 21);
            this.rbSelesai.TabIndex = 109;
            this.rbSelesai.Text = "Selesai";
            this.rbSelesai.UseVisualStyleBackColor = true;
            // 
            // rbBelumSelesai
            // 
            this.rbBelumSelesai.AutoSize = true;
            this.rbBelumSelesai.Checked = true;
            this.rbBelumSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbBelumSelesai.Location = new System.Drawing.Point(227, 256);
            this.rbBelumSelesai.Name = "rbBelumSelesai";
            this.rbBelumSelesai.Size = new System.Drawing.Size(128, 21);
            this.rbBelumSelesai.TabIndex = 110;
            this.rbBelumSelesai.TabStop = true;
            this.rbBelumSelesai.Text = "Belum Selesai";
            this.rbBelumSelesai.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Waiting",
            "Registered",
            "Queued",
            "Applied"});
            this.cbStatus.Location = new System.Drawing.Point(2, 2);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbStatus.Size = new System.Drawing.Size(305, 23);
            this.cbStatus.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Location = new System.Drawing.Point(114, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 27);
            this.panel2.TabIndex = 116;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(113, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 24);
            this.panel3.TabIndex = 117;
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.label10);
            this.pnlProgress.Controls.Add(this.tbProgress);
            this.pnlProgress.Controls.Add(this.label6);
            this.pnlProgress.Controls.Add(this.label3);
            this.pnlProgress.Controls.Add(this.panel4);
            this.pnlProgress.Location = new System.Drawing.Point(10, 91);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(431, 42);
            this.pnlProgress.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(183, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "%";
            // 
            // tbProgress
            // 
            this.tbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProgress.Location = new System.Drawing.Point(114, 13);
            this.tbProgress.MaxLength = 2;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(63, 20);
            this.tbProgress.TabIndex = 121;
            this.tbProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(95, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 120;
            this.label6.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Progress";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(112, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(67, 24);
            this.panel4.TabIndex = 123;
            // 
            // pnlNote
            // 
            this.pnlNote.Controls.Add(this.tbNotes);
            this.pnlNote.Controls.Add(this.panel3);
            this.pnlNote.Controls.Add(this.label4);
            this.pnlNote.Controls.Add(this.label7);
            this.pnlNote.Location = new System.Drawing.Point(10, 147);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(431, 42);
            this.pnlNote.TabIndex = 124;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.panel2);
            this.pnlStatus.Controls.Add(this.label1);
            this.pnlStatus.Controls.Add(this.label8);
            this.pnlStatus.Location = new System.Drawing.Point(10, 202);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(431, 42);
            this.pnlStatus.TabIndex = 125;
            // 
            // lblKategori
            // 
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(324, 65);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKategori.Size = new System.Drawing.Size(206, 24);
            this.lblKategori.TabIndex = 118;
            this.lblKategori.Text = "Kategori";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 362);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.rbBelumSelesai);
            this.Controls.Add(this.rbSelesai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Hai! Produktif | Edit Catatan Kegiatan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.RadioButton rbSelesai;
        private System.Windows.Forms.RadioButton rbBelumSelesai;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblKategori;
    }
}
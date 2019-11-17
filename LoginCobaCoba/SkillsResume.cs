using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCobaCoba
{
    public partial class SkillsResume : Form
    {
        public SkillsResume()
        {
            InitializeComponent();

            //Menampilkan informasi user 
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            lblSkill.Text = Data.rsm_kategori;
            lblGoing.Text = Data.rsm_going;
            lblHistory.Text = Data.rsm_history;
            lblAchievements.Text = Data.rsm_achievements;
            lblTotal.Text = (Data.rsm_total - Data.rsm_going_count).ToString() + " / " + (Data.rsm_total).ToString();

            // Memeriksa apakah rsm_total bernilai 0 sekaligus untuk menghindari operasi pembagian nilai 0
            if (Data.rsm_total == 0) lblRsm.Text = "0%";
            else
            {
                float progress = ((float)(Data.rsm_total - Data.rsm_going_count) / (float)Data.rsm_total) * 100;
                lblRsm.Text = Convert.ToInt32(progress) + "%";

                // Mengganti foto background sesuai jumlah progress
                if (progress == 0) { } // do nothing
                else if (progress <= 25) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume2;
                else if (progress <= 50) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume3;
                else if (progress <= 75) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume4;
                else if (progress <= 100) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume5;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        // Log out dan restart aplikasi 
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Menuju form Home
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        // Menuju form Task
        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tasks task = new Tasks();
            task.ShowDialog();
        }

        // Button exit 
        private void button7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Menuju form Skills
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        // Menuju form Profile
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Menampilkan Form SkillEditor
            SkillEditor editor = new SkillEditor(lblSkill.Text);
            editor.ShowDialog();

            // Menampilkan ulang form dengan data yang sudah diperbarui
            lblHistory.Text = Data.rsm_history;
            lblAchievements.Text = Data.rsm_achievements;
            lblTotal.Text = (Data.rsm_total - Data.rsm_going_count).ToString() + " / " + (Data.rsm_total).ToString();

            float progress = ((float)(Data.rsm_total - Data.rsm_going_count) / (float)Data.rsm_total) * 100;
            lblRsm.Text = Convert.ToInt32(progress) + "%";

            if (progress <= 25) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume2;
            else if (progress <= 50) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume3;
            else if (progress <= 75) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume4;
            else if (progress <= 100) pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources.Resume5;
        }
    }
}

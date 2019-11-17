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
    public partial class Skill : Form
    {
        public Skill()
        {
            InitializeComponent();
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
        }

        // Log out dan restart Aplikasi
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Menuju ke form Home
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        // Menuju ke form Task
        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tasks task = new Tasks();
            task.ShowDialog();
        }

        // Exit
        private void button7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Menuju ke form Profile
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        Data data = new Data();
        //
        // Menuju ke form SkillResume sesuai dengan kategori yang dipilih dengan parameter teks
        //
        private void button1_Click(object sender, EventArgs e)
        {
            data.Resume(button1.Text);
            Resume();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Resume(button2.Text);
            Resume();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            data.Resume(button8.Text);
            Resume();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            data.Resume(button9.Text);
            Resume();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            data.Resume(button10.Text);
            Resume();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            data.Resume(button11.Text);
            Resume();
        }

        private void Resume()
        {
            SkillsResume resume = new SkillsResume();
            this.Visible = false;
            resume.ShowDialog();
        }
    }
}

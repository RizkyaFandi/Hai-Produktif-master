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
    public partial class Tasks : Form
    {
        DataTasks data = new DataTasks();

        public Tasks()
        {
            InitializeComponent();

            // Menampilkan nama dan username
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;

            // Menampilkan daftar lomba yang diambil user
            data.Experience(lblUser.Text);
            label8.Text = Data.ex_lomba1;
            label11.Text = Data.ex_lomba2;
            label17.Text = Data.ex_lomba3;
            DL_Lomba();

            // Menampilkan daftar lowongan kerja yang diambil user
            label33.Text = Data.ex_loker1;
            label30.Text = Data.ex_loker2;
            label23.Text = Data.ex_loker3;
            Applied_Loker();

            // Menampilkan daftar event yang diambil user
            label49.Text = Data.ex_event1;
            label46.Text = Data.ex_event2;
            label39.Text = Data.ex_event3;
            Date_Event();
        }

        // Mendapatkan deadline dari lomba yang ada di daftar
        private void DL_Lomba()
        {
            if (label8.Text != "")
            {
                data.Lomba(label8.Text);
                label7.Text = DataTasks.l_deadline;
            }
            if (label11.Text != "")
            {
                data.Lomba(label11.Text);
                label10.Text = DataTasks.l_deadline;
            }
            if (label17.Text != "")
            {
                data.Lomba(label17.Text);
                label16.Text = DataTasks.l_deadline;
            }
        }

        // Mendapatkan tanggal apply dari lowongan kerja yang ada di daftar
        private void Applied_Loker()
        {
            if (label33.Text != "")
            {
                data.Loker(label33.Text);
                label32.Text = DataTasks.lk_dateapplied;
            }
            if (label30.Text != "")
            {
                data.Loker(label30.Text);
                label27.Text = DataTasks.lk_dateapplied;
            }
            if (label23.Text != "")
            {
                data.Loker(label23.Text);
                label22.Text = DataTasks.lk_dateapplied;
            }
        }

        // Mendapatkan tanggal dari event yang ada di daftar
        private void Date_Event()
        {
            if (label49.Text != "")
            {
                data.Event(label49.Text);
                label48.Text = DataTasks.e_date;
            }
            if (label46.Text != "")
            {
                data.Event(label46.Text);
                label43.Text = DataTasks.e_date;
            }
            if (label39.Text != "")
            {
                data.Event(label39.Text);
                label38.Text = DataTasks.e_date;
            }
        }

        // Me-restart aplikasi jika user ingin log out
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Membuka menu Home
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        // Membuka menu Skill
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        // Menutup aplikasi
        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Membuka profil user
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        //
        // Membuka data lengkap task yang di-klik
        //

        private void Label8_Click(object sender, EventArgs e)
        {
            data.Lomba(label8.Text);
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            data.Lomba(label11.Text);
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        private void Label17_Click(object sender, EventArgs e)
        {
            data.Lomba(label17.Text);
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        private void Label33_Click(object sender, EventArgs e)
        {
            data.Loker(label33.Text);
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        private void Label30_Click(object sender, EventArgs e)
        {
            data.Loker(label30.Text);
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        private void Label23_Click(object sender, EventArgs e)
        {
            data.Loker(label23.Text);
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        private void Label49_Click(object sender, EventArgs e)
        {
            data.Event(label49.Text);
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        private void Label46_Click(object sender, EventArgs e)
        {
            data.Event(label46.Text);
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        private void Label39_Click(object sender, EventArgs e)
        {
            data.Event(label39.Text);
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        //
        // Mengubah warna teks ketika ditunjuk cursor
        //

        private void Label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = ColorTranslator.FromHtml("#af4ef1");
 
        }

        private void Label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label33_MouseEnter(object sender, EventArgs e)
        {
            label33.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label33_MouseLeave(object sender, EventArgs e)
        {
            label33.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label30_MouseEnter(object sender, EventArgs e)
        {
            label30.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label30_MouseLeave(object sender, EventArgs e)
        {
            label30.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label23_MouseEnter(object sender, EventArgs e)
        {
            label23.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label23_MouseLeave(object sender, EventArgs e)
        {
            label23.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label49_MouseEnter(object sender, EventArgs e)
        {
            label49.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label49_MouseLeave(object sender, EventArgs e)
        {
            label49.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label46_MouseEnter(object sender, EventArgs e)
        {
            label46.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label46_MouseLeave(object sender, EventArgs e)
        {
            label46.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void Label39_MouseEnter(object sender, EventArgs e)
        {
            label39.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void Label39_MouseLeave(object sender, EventArgs e)
        {
            label39.ForeColor = ColorTranslator.FromHtml("#272727");
        }
    }
}

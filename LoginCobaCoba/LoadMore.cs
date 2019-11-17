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
    public partial class LoadMore : Form
    {
        public LoadMore()
        {
            InitializeComponent();

            // Menyiapkan data user dan mengecek apakah task sudah diambil user
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            Lomba_Exist();
            Loker_Exist();
            Event_Exist();
        }

        // Me-restart aplikasi jik user ingin log out
        private void button22_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Membuka menu Skill
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        // Membuka menu Tasks
        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tasks task = new Tasks();
            task.ShowDialog();
        }

        // Menutup aplikasi
        private void button23_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Membuka menu Home
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        DataTasks data = new DataTasks();
        FormLomba formLomba = new FormLomba();
        FormEvent formEvent = new FormEvent();
        LowonganKerja loker = new LowonganKerja();
        //
        //Lomba
        //

        private void Lomba_Exist() // Cek lomba sudah diambil atau belum
        {
            button8.Text = formLomba.IsExist(label8.Text);
            button9.Text = formLomba.IsExist(label17.Text);
            button10.Text = formLomba.IsExist(label11.Text);
            button3.Text = formLomba.IsExist(label20.Text);
            button2.Text = formLomba.IsExist(label14.Text);
            button1.Text = formLomba.IsExist(label3.Text);
        }

        // Membuka formLomba dengan isi sesuai lomba yang dipilih

        private void label8_Click(object sender, EventArgs e)
        {
            data.Lomba(label8.Text);
            Lomba();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            data.Lomba(label17.Text);
            Lomba();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            data.Lomba(label11.Text);
            Lomba();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            data.Lomba(label20.Text);
            Lomba();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            data.Lomba(label14.Text);
            Lomba();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            data.Lomba(label3.Text);
            Lomba();
        }

        //
        //Loker
        //

        private void Loker_Exist() // Cek apakah lowongan kerja sudah diambil user
        {
            button15.Text = loker.IsExist(label41.Text);
            button14.Text = loker.IsExist(label38.Text);
            button13.Text = loker.IsExist(label35.Text);
            button12.Text = loker.IsExist(label29.Text);
            button11.Text = loker.IsExist(label26.Text);
            button7.Text = loker.IsExist(label23.Text);
        }

        // Membuka form LowonganKerja berdasarkan lowongan kerja yang dipilih

        private void label41_Click(object sender, EventArgs e)
        {
            data.Loker(label41.Text);
            Lowker();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            data.Loker(label38.Text);
            Lowker();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            data.Loker(label35.Text);
            Lowker();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            data.Loker(label29.Text);
            Lowker();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            data.Loker(label26.Text);
            Lowker();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            data.Loker(label23.Text);
            Lowker();
        }

        //
        //Event
        //

        private void Event_Exist() // Cek apakah event sudah diambil user
        {
            button21.Text = formEvent.IsExist(label61.Text);
            button20.Text = formEvent.IsExist(label58.Text);
            button19.Text = formEvent.IsExist(label55.Text);
            button18.Text = formEvent.IsExist(label50.Text);
            button17.Text = formEvent.IsExist(label47.Text);
            button16.Text = formEvent.IsExist(label44.Text);
        }

        // Membuka formEvent berdasarkan event yang dipilih

        private void label61_Click(object sender, EventArgs e)
        {
            data.Event(label61.Text);
            Event();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            data.Event(label58.Text);
            Event();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            data.Event(label55.Text);
            Event();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            data.Event(label50.Text);
            Event();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            data.Event(label47.Text);
            Event();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            data.Event(label44.Text);
            Event();
        }

        // Membuka formLomba
        public void Lomba()
        {
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        // Membuka form LowonganKerja
        public void Lowker()
        {
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        // Membuka formEvent
        public void Event()
        {
            FormEvent events = new FormEvent();
            this.Visible = false;
            events.ShowDialog();
        }

        // Kembali ke menu Home
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        // Membuka profil user
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        //
        // Ubah mode add ke remove atau sebaliknya dan menambah atau menghapus task yang dipilih
        //

        // Lomba
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = formLomba.Tasks(button8.Text, lblUser.Text, label8.Text);
            data.Experience(lblUser.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = formLomba.Tasks(button9.Text, lblUser.Text, label17.Text);
            data.Experience(lblUser.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = formLomba.Tasks(button10.Text, lblUser.Text, label11.Text);
            data.Experience(lblUser.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = formLomba.Tasks(button3.Text, lblUser.Text, label20.Text);
            data.Experience(lblUser.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = formLomba.Tasks(button2.Text, lblUser.Text, label14.Text);
            data.Experience(lblUser.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = formLomba.Tasks(button1.Text, lblUser.Text, label3.Text);
            data.Experience(lblUser.Text);
        }

        // Loker

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = loker.Tasks(button15.Text, lblUser.Text, label41.Text);
            data.Experience(lblUser.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = loker.Tasks(button14.Text, lblUser.Text, label38.Text);
            data.Experience(lblUser.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = loker.Tasks(button13.Text, lblUser.Text, label35.Text);
            data.Experience(lblUser.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = loker.Tasks(button12.Text, lblUser.Text, label29.Text);
            data.Experience(lblUser.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = loker.Tasks(button11.Text, lblUser.Text, label26.Text);
            data.Experience(lblUser.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = loker.Tasks(button7.Text, lblUser.Text, label23.Text);
            data.Experience(lblUser.Text);
        }

        // Events

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = formEvent.Tasks(button21.Text, lblUser.Text, label61.Text);
            data.Experience(lblUser.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Text = formEvent.Tasks(button20.Text, lblUser.Text, label58.Text);
            data.Experience(lblUser.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Text = formEvent.Tasks(button19.Text, lblUser.Text, label55.Text);
            data.Experience(lblUser.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Text = formEvent.Tasks(button18.Text, lblUser.Text, label50.Text);
            data.Experience(lblUser.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = formEvent.Tasks(button17.Text, lblUser.Text, label47.Text);
            data.Experience(lblUser.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = formEvent.Tasks(button16.Text, lblUser.Text, label44.Text);
            data.Experience(lblUser.Text);
        }
    }
}

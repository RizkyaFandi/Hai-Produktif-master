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
    public partial class FormLomba : Form
    {
        Data data = new Data();

        public FormLomba()
        {
            InitializeComponent();

            Data.selesai = false;

            // Menyiapkan data lomba yang dipilih
            lblFLName.Text = Data.first_name + " " + DataTasks.last_name;
            lblUser.Text = Data.uname;
            lblName.Text = DataTasks.l_name;
            lblAuthDate.Text = DataTasks.l_authdate;
            lblDesc.Text = DataTasks.l_desc;
            lblDl.Text = DataTasks.l_deadline;
            lblCp.Text = DataTasks.l_contact;
            lblProgress.Text = DataTasks.l_progress;
            lblNote.Text = DataTasks.l_note;

            // Mengecek apakah user sudah mengambil lomba atau belum
            data.Experience(lblUser.Text);
            button1.Text = IsExist(lblName.Text);
            ColorChanger(button1.Text);

            // Membuka gambar poster lomba sesuai lomba yang dipilih
            if (lblName.Text == "Bukalapak Kreasi")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._8;
            }
            else if (lblName.Text == "Jenius Hackathon SEA")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._7;
            }
            else if (lblName.Text == "Lomba Blog Domainesia")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._10;
            }
            else if (lblName.Text == "Lomba Blog Travel Umroh")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._9;
            }
            else if (lblName.Text == "Lomba Paper #FutureIndonesia")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._12;
            }
            else if (lblName.Text == "Lomba Selfie Relaxing Moment")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._11;
            }
        }

        public string IsExist(string lomba) // Mengecek apakah lomba sudah ada di task
        {
            if(Data.ex_lomba1==lomba || Data.ex_lomba2 == lomba || Data.ex_lomba3 == lomba)
            {
                return "remove from task";
            }
            else
            {
                return "add to task";
            }
        }

        // Menutup aplikasi
        private void button7_Click(object sender, EventArgs e)
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

        // Me-restart aplikasi jika user ingin log out
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Kembali ke menu LoadMore untuk memilih task lain
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadMore load = new LoadMore();
            load.ShowDialog();
        }

        // Membuka profil user
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        // Menambahkan atau menghapus lomba dari database Experience
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Tasks(button1.Text, lblUser.Text, lblName.Text);
            data.Experience(lblUser.Text);
            ColorChanger(button1.Text);
        }

        // Mengubah warna teks sesuai teks yang ditampilkan button1
        private void ColorChanger(string tex)
        {
            if (tex == "add to task")
            {
                button1.BackColor = ColorTranslator.FromHtml("#2E8B57");
                button3.Enabled = false;
            }
            else if (tex == "remove from task")
            {
                button1.BackColor = ColorTranslator.FromHtml("#800000");
                button3.Enabled = true;
            }
        }

        public string Tasks(string task, string user, string lomba)
        {
            if (task == "add to task")
            {
                // memeriksa apakah kegiatan yang diambil sudah pernah diselesaikan atau belum
                using (var db = new DBModel())
                {
                    var minat = (from data in db.Lomba where data.Name == lomba select data).FirstOrDefault();

                    if (minat.Minat == "Desain")
                    {
                        var history = from catatan in db.Desain where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Bisnis")
                    {
                        var history = from catatan in db.Bisnis where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "IT")
                    {
                        var history = from catatan in db.IT where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Jurnalisme")
                    {
                        var history = from catatan in db.Jurnalisme where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Riset")
                    {
                        var history = from catatan in db.Riset where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat=="Umum")
                    {
                        var history = from catatan in db.Umum where catatan.History == lomba select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + lomba + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    } // end of searching category
                }
                // end of check data

                // Mengecek apakah user masih bisa menambahkan task lomba atau tidak dan menambahkan lomba jika masih bisa
                Boolean status = true;
                if (Data.ex_lomba1 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Lomba1 = lomba;
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_lomba2 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Lomba2 = lomba;
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_lomba3 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Lomba3 = lomba;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Task lomba Anda penuh!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    status = false;
                }

                if (status == true)
                {
                    using (var db = new DBModel())
                    {
                        var query = (from data in db.Notes where ((data.Akun == user) && (data.NameLomba == "-")) select data).FirstOrDefault();

                        query.NameLomba = lomba;
                        db.SaveChanges();
                    }

                    MessageBox.Show("Task ditambahkan!", "Penambahan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    task = "remove from task";
                }
            }

            // Menghapus task lomba yang diinginkan user
            else if (task == "remove from task")
            {
                Experience experience = new Experience();
                if (Data.ex_lomba1 == lomba)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Lomba1 = Data.ex_lomba2;
                            result.Lomba2 = Data.ex_lomba3;
                            result.Lomba3 = "";
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_lomba2 == lomba)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Lomba2 = Data.ex_lomba3;
                        result.Lomba3 = "";
                        db.SaveChanges();
                    }
                }
                else if (Data.ex_lomba3 == lomba)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Lomba3 = "";
                        db.SaveChanges();
                    }
                }

                using (var db = new DBModel())
                {
                    var query = (from data in db.Notes where ((data.Akun == user) && (data.NameLomba == lomba)) select data).FirstOrDefault();

                    query.NameLomba = "-"; query.ProgressLomba = "0"; query.NoteLomba = "-";
                    db.SaveChanges();
                }

                DataTasks.l_progress = "-"; DataTasks.l_note = "-"; 
                lblProgress.Text = DataTasks.l_progress; lblNote.Text = DataTasks.l_note;
                MessageBox.Show("Task dihapus!", "Penghapusan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                task = "add to task";
            }
            return task;
        }

        // Membuka EditForm jika di-klik dengan syarat lomba sudah ada di task user 
        private void button3_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(lblName.Text, lblProgress.Text, lblNote.Text, "Lomba");
            edit.ShowDialog();

            if (Data.selesai) // tanda kegiatannya sudah diselesaikan
            {
                this.Close();
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                lblProgress.Text = DataTasks.l_progress; lblNote.Text = DataTasks.l_note;
            }
        }
    }
}

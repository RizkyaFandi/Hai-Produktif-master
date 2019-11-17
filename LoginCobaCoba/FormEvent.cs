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
    public partial class FormEvent : Form
    {
        DataTasks data = new DataTasks();

        public FormEvent()
        {
            InitializeComponent();

            Data.selesai = false;

            // Menyiapkan data event yang di-klik dan mengecek apakah event sudah diambil user
            lblFLName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            lblName.Text = DataTasks.e_name;
            lblAuthDate.Text = DataTasks.e_authdate;
            lblDesc.Text = DataTasks.e_desc;
            lblDate.Text = DataTasks.e_date;
            lblStatus.Text = DataTasks.e_status;
            lblNote.Text = DataTasks.e_note;
            data.Experience(lblUser.Text);
            button1.Text = IsExist(lblName.Text);
            ColorChanger(button1.Text); // Mengubah warna text sesuai mode (add atau remove)

            // Membuka gambar poster yang sesuai dengan event yang dipilih
            if (lblName.Text == "Entrepreneur Day")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._5;
            }
            else if (lblName.Text == "Find IT!")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._1;
            }
            else if (lblName.Text == "Journartlism")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._6;
            }
            else if (lblName.Text == "NESCO")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._2;
            }
            else if (lblName.Text == "Public Speaking Training")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._4;
            }
            else if (lblName.Text == "Technocorner")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._3;
            }
        }

        public string IsExist(string Event) // Mengecek apakah event sudah ada di task
        {
            if (DataTasks.ex_event1 == Event || DataTasks.ex_event2 == Event || DataTasks.ex_event3 == Event)
            {
                return "remove from task";
            }
            else
            {
                return "add to task";
            }
        }

        // Membuka menu Home jika di-klik
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        // Membuka menu Skill jika di-klik
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        // Membuka menu Tasks jika di-klik
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

        // Menutup aplikasi
        private void button7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Kembali ke menu Load More jika user ingin membuka semua kegiatan lagi
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadMore load = new LoadMore();
            load.ShowDialog();
        }
        
        // Membuka form Profile dengan data user
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        // Menambahkan atau menghapus event dari database Akun
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Tasks(button1.Text, lblUser.Text, lblName.Text);
            data.Experience(lblUser.Text);
            ColorChanger(button1.Text);
        }

        // Mengubah warna teks sesuai teks yang diinputkan dan memutuskan apakah Edit akan bisa di-klik
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

        public string Tasks(string task, string user, string Event)
        {
            if (task == "add to task")
            {
                // memeriksa apakah kegiatan yang diambil sudah pernah diselesaikan atau belum
                using (var db = new DBModel())
                {
                    var minat = (from data in db.Events where data.Name == Event select data).FirstOrDefault();

                    if (minat.Minat == "Desain")
                    {
                        var history = from catatan in db.Desain where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Bisnis")
                    {
                        var history = from catatan in db.Bisnis where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "IT")
                    {
                        var history = from catatan in db.IT where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Jurnalisme")
                    {
                        var history = from catatan in db.Jurnalisme where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Riset")
                    {
                        var history = from catatan in db.Riset where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Umum")
                    {
                        var history = from catatan in db.Umum where catatan.History == Event select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Event + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    } // end of searching category
                }
                // end of check

                // Mengecek apakah user masih bisa menambahkan task atau tidak
                Boolean status = true;
                if (DataTasks.ex_event1 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Event1 = Event;
                            db.SaveChanges();
                        }
                    }
                }
                else if (DataTasks.ex_event2 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Event2 = Event;
                            db.SaveChanges();
                        }
                    }
                }
                else if (DataTasks.ex_event3 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Event3 = Event;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Task event Anda penuh!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    status = false;
                }

                // Jika belum penuh maka task akan ditambahkan
                if (status == true)
                {
                    using (var db = new DBModel())
                    {
                        var query = (from data in db.Notes where ((data.Akun == user) && (data.NameEvent == "-")) select data).FirstOrDefault();

                        query.NameEvent = Event;
                        db.SaveChanges();
                    }

                    MessageBox.Show("Task ditambahkan!", "Penambahan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    task = "remove from task";
                }
            } // end of add to task statement

            // Menghapus task yang sudah diambil
            else if (task == "remove from task")
            {
                Experience experience = new Experience();
                if (DataTasks.ex_event1 == Event)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Event1 = DataTasks.ex_event2;
                            result.Event2 = DataTasks.ex_event3;
                            result.Event3 = "";
                            db.SaveChanges();
                        }
                    }
                }
                else if (DataTasks.ex_event2 == Event)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Event2 = DataTasks.ex_event3;
                        result.Event3 = "";
                        db.SaveChanges();
                    }
                }
                else if (DataTasks.ex_event3 == Event)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Event3 = "";
                        db.SaveChanges();
                    }
                }

                using (var db = new DBModel())
                {
                    var query = (from data in db.Notes where ((data.Akun == user) && (data.NameEvent == Event)) select data).FirstOrDefault();

                    query.NameEvent = "-"; query.StatusEvent = "-"; query.NoteEvent = "-";
                    db.SaveChanges();
                }

                DataTasks.e_status = "-"; DataTasks.e_note = "-"; 
                lblStatus.Text = DataTasks.e_status; lblNote.Text = DataTasks.e_note; 
                MessageBox.Show("Task dihapus!", "Penghapusan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                task = "add to task";
            } // end of remove from task statement
            return task;
        }

        // Membuka form EditForm jika button edit di-klik dengan syarat event sudah di "add to task"
        private void button3_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(lblName.Text, lblNote.Text, lblStatus.Text, "Event");
            edit.ShowDialog();

            if (Data.selesai) // tanda kegiatannya sudah diselesaikan
            {
                this.Close();
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                lblStatus.Text = DataTasks.e_status; lblNote.Text = DataTasks.e_note;
            }
        }
    }
}

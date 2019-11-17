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
    public partial class LowonganKerja : Form
    {
        Data data = new Data();

        public LowonganKerja()
        {
            InitializeComponent();

            Data.selesai = false;

            // Menyiapkan data user
            lblUser.Text = Data.uname;
            data.Experience(lblUser.Text);

            // Menyiapkan data lowongan kerja terpilih
            lblFLName.Text = Data.first_name + " " + Data.last_name;
            lblName.Text = DataTasks.lk_name;
            lblAuthDate.Text = DataTasks.lk_authdate;
            lblDesc.Text = DataTasks.lk_desc;
            lblCriteria.Text = DataTasks.lk_criteria;
            lblStatus.Text = DataTasks.lk_status;
            lblNote.Text = DataTasks.lk_note;
            lblApplied.Text = DataTasks.lk_dateapplied;

            // Mengecek apakah lowongan kerja sudah diambil user
            button1.Text = IsExist(lblName.Text);
            ColorChanger(button1.Text);

            // Menampilkan gambar logo penawar lowongan kerja sesuai lowongan yang dipilih
            if (lblName.Text == "Export Import Officer")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._13;
            }
            else if (lblName.Text == "Financial Specialist")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._14;
            }
            else if (lblName.Text == "Junior Associate Accountant")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._15;
            }
            else if (lblName.Text == "Junior Software Engineering Traveloka")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._18;
            }
            else if (lblName.Text == "Senior Data Scientist Bukalapak")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._16;
            }
            else if (lblName.Text == "Staff IT (Maintain Core System)")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._17;
            }
        }

        public string IsExist(string Loker) // Mengecek apakah lowongan kerja sudah ada di task
        {
            if (Data.ex_loker1 == Loker || Data.ex_loker2 == Loker || Data.ex_loker3 == Loker)
            {
                return "remove from task";
            }
            else
            {
                return "add to task";
            }
        }

        // Me-restart aplikasi jika user ingin log out
        private void button2_Click(object sender, EventArgs e)
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

        // Kembali ke menu LoadMore
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

        private void button1_Click(object sender, EventArgs e) // button Add to Task atau Remove from Task
        {
            button1.Text = Tasks(button1.Text, lblUser.Text, lblName.Text);
            data.Experience(lblUser.Text);
            ColorChanger(button1.Text);
        }

        // Mengubah warna teks sesuai teks yang diinputkan dan memutuskan apakah edit bisa di-klik
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

        public string Tasks(string task, string user, string Loker)
        {
            if (task == "add to task")
            {
                // memeriksa apakah kegiatan yang diambil sudah pernah diselesaikan atau belum
                using (var db = new DBModel())
                {
                    var minat = (from data in db.Loker where data.Name == Loker select data).FirstOrDefault();

                    if (minat.Minat == "Desain")
                    {
                        var history = from catatan in db.Desain where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Bisnis")
                    {
                        var history = from catatan in db.Bisnis where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "IT")
                    {
                        var history = from catatan in db.IT where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Jurnalisme")
                    {
                        var history = from catatan in db.Jurnalisme where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Riset")
                    {
                        var history = from catatan in db.Riset where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    }
                    else if (minat.Minat == "Umum")
                    {
                        var history = from catatan in db.Umum where catatan.History == Loker select catatan;
                        if (history.Any())
                        {
                            MessageBox.Show("Kegiatan " + Loker + " sudah pernah diselesaikan sebelumnya. Tidak dapat menambahkan kegiatan ini lagi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return task;
                        }
                    } // end of searching category
                }
                // end of check

                // Mengecek apakah user masih bisa menambahkan task lowongan kerja
                Boolean status = true;
                string temp = "";
                if (Data.ex_loker1 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Loker1 = Loker;
                            temp = (DateTime.Now).ToString();
                            result.ApplyLoker1 = DateTime.Parse(temp).ToString("dd/MM/yyyy");
                            lblApplied.Text = result.ApplyLoker1;
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_loker2 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Loker2 = Loker;
                            temp = (DateTime.Now).ToString();
                            result.ApplyLoker2 = DateTime.Parse(temp).ToString("dd/MM/yyyy");
                            lblApplied.Text = result.ApplyLoker2;
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_loker3 == "")
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Loker3 = Loker;
                            temp = (DateTime.Now).ToString();
                            result.ApplyLoker3 = DateTime.Parse(temp).ToString("dd/MM/yyyy");
                            lblApplied.Text = result.ApplyLoker3;
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Task lowongan kerja Anda penuh!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    status = false;
                }

                if (status == true)
                {
                    using (var db = new DBModel())
                    {
                        var query = (from data in db.Notes where ((data.Akun == user) && (data.NameLoker == "-")) select data).FirstOrDefault();

                        query.NameLoker = Loker;
                        db.SaveChanges();
                    }

                    MessageBox.Show("Task ditambahkan!", "Penambahan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    task = "remove from task";
                }
            } // end of add to task statement

            // Menghapus task yang diinginkan
            else if (task == "remove from task")
            {
                Experience experience = new Experience();
                if (Data.ex_loker1 == Loker)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        {
                            result.Loker1 = Data.ex_loker2;
                            result.Loker2 = Data.ex_loker3;
                            result.Loker3 = "";
                            result.ApplyLoker1 = Data.ex_applyLoker2;
                            result.ApplyLoker2 = Data.ex_applyLoker3;
                            result.ApplyLoker3 = "";
                            db.SaveChanges();
                        }
                    }
                }
                else if (Data.ex_loker2 == Loker)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Loker2 = Data.ex_loker3;
                        result.Loker3 = "";
                        result.ApplyLoker2 = Data.ex_applyLoker3;
                        result.ApplyLoker3 = "";
                        db.SaveChanges();
                    }
                }
                else if (Data.ex_loker3 == Loker)
                {
                    using (var db = new DBModel())
                    {
                        var result = db.Experience.SingleOrDefault(k => k.Akun == user);
                        result.Loker3 = "";
                        result.ApplyLoker3 = "";
                        db.SaveChanges();
                    }
                }

                using (var db = new DBModel())
                {
                    var query = (from data in db.Notes where ((data.Akun == user) && (data.NameLoker == Loker)) select data).FirstOrDefault();

                    query.NameLoker = "-"; query.StatusLoker = "-"; query.NoteLoker = "-";
                    db.SaveChanges();
                }

                DataTasks.lk_status = "-"; DataTasks.lk_note = "-"; DataTasks.lk_dateapplied = "-";
                lblStatus.Text = DataTasks.lk_status; lblNote.Text = DataTasks.lk_note; lblApplied.Text = DataTasks.lk_dateapplied; 
                MessageBox.Show("Task dihapus!", "Penghapusan data berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                task = "add to task";
            }
            return task;
        } // end of remove from task statement

        // Membuka form EditForm jika edit di-klik
        private void Button3_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(lblName.Text, lblNote.Text, lblStatus.Text, "Lowongan Pekerjaan");
            edit.ShowDialog();

            if (Data.selesai) // tanda kegiatannya sudah diselesaikan
            {
                this.Close();
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                lblStatus.Text = DataTasks.lk_status; lblNote.Text = DataTasks.lk_note;
            }
        }
    }
}

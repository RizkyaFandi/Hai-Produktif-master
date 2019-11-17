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
    public partial class EditForm : Form
    {
        public string nama, skill;

        public EditForm(string namaKegiatan, string dataAtas, string dataBawah, string kategori)
        {
            InitializeComponent();

            nama = namaKegiatan;

            // Menerima catatan kecil dari page Event / Lomba / Lowongan Pekerjaan
            // sekaligus menonaktifkan bar yang sekiranya tidak terpakai dari kegiatan
            if (kategori == "Event")
            {
                pnlProgress.Enabled = false;
                tbNotes.Text = dataAtas;
                cbStatus.Text = dataBawah;
                lblKategori.Text = kategori;
            }
            else if (kategori == "Lomba")
            {
                pnlStatus.Enabled = false;
                tbProgress.Text = dataAtas.Replace("%","");
                tbNotes.Text = dataBawah;
                lblKategori.Text = kategori;
            }
            else if (kategori == "Lowongan Pekerjaan")
            {
                pnlProgress.Enabled = false;
                tbNotes.Text = dataAtas;
                cbStatus.Text = dataBawah;
                lblKategori.Text = kategori;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData(); // beralih ke method EditData
        }

        private void EditData()
        {
            string message = "Yakin sudah menyelesaikan kegiatan ini?";
            string title = "Konfirmasi edit kegiatan";
            // instance class Data
            Data dataClass = new Data();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (lblKategori.Text == "Event")
            {
                //check button yang dipilih
                if (rbSelesai.Checked)
                {
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes) // pengguna menekan tombol Yes
                    {
                        FormEvent events = new FormEvent();
                        // melakukan fungsi remove from task di class FormEvent
                        string pesan = events.Tasks("remove from task", Data.uname, nama);
                        dataClass.Experience(Data.uname);
                        History(pesan);
                    }
                } // end of if rbSelesai checked

                else if (rbBelumSelesai.Checked)
                {
                    if ((cbStatus.Text == "") || (tbNotes.Text == ""))
                        MessageBox.Show("Semua box harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
                        {
                            var query = 
                                (from data in db.Notes
                                 where ((data.Akun == Data.uname) && (data.NameEvent == nama))
                                 select data).FirstOrDefault();
                            
                            // Memperbarui value di database
                            query.StatusEvent = cbStatus.Text; query.NoteEvent = tbNotes.Text;
                            db.SaveChanges();

                            MessageBox.Show("Data telah diganti!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTasks.e_status = cbStatus.Text; DataTasks.e_note = tbNotes.Text;
                            this.Close();
                        }
                    }
                }
            } // end of if Event statement

            else if (lblKategori.Text == "Lomba")
            {
                // check button yang dipilih
                if (rbSelesai.Checked)
                {
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes) // pengguna menekan tombol Yes
                    {
                        FormLomba lomba = new FormLomba();
                        // melakukan fungsi remove from task di class FormLomba
                        string pesan = lomba.Tasks("remove from task", Data.uname, nama);
                        dataClass.Experience(Data.uname);
                        History(pesan);
                    }
                } // end of if rbSelesai checked

                else if (rbBelumSelesai.Checked)
                {
                    if ((tbProgress.Text == "") || (tbNotes.Text == ""))
                        MessageBox.Show("Semua box harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        int parse;
                        bool correct = Int32.TryParse(tbProgress.Text, out parse);

                        if (correct)
                        {
                            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
                            {
                                var query = 
                                    (from data in db.Notes
                                     where ((data.Akun == Data.uname) && (data.NameLomba == nama))
                                     select data).FirstOrDefault();

                                // Memperbarui value di database
                                query.ProgressLomba = tbProgress.Text; query.NoteLomba = tbNotes.Text;
                                db.SaveChanges();

                                MessageBox.Show("Data telah diganti!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DataTasks.l_progress = tbProgress.Text + "%"; DataTasks.l_note = tbNotes.Text;
                                this.Close();
                            }
                        }
                        else MessageBox.Show("Box progress harus diisi dengan angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } // end of if Lomba statement

            else if (lblKategori.Text == "Lowongan Pekerjaan")
            {
                // check button yang dipilih
                if (rbSelesai.Checked)
                {
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes) // pengguna menekan tombol Yes
                    {
                        LowonganKerja loker = new LowonganKerja();
                        // melakukan fungsi remove from task di class LowonganKerja
                        string pesan = loker.Tasks("remove from task", Data.uname, nama);
                        dataClass.Experience(Data.uname);
                        History(pesan);
                    }
                } // end of if rbSelesai checked


                else if (rbBelumSelesai.Checked)
                {
                    if ((cbStatus.Text == "") || (tbNotes.Text == ""))
                        MessageBox.Show("Semua box harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
                        {
                            var query = 
                                (from data in db.Notes
                                 where ((data.Akun == Data.uname) && (data.NameLoker == nama))
                                 select data).FirstOrDefault();

                            // Memperbarui value di database
                            query.StatusLoker = cbStatus.Text; query.NoteLoker = tbNotes.Text;
                            db.SaveChanges();

                            MessageBox.Show("Data telah diganti!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTasks.lk_status = cbStatus.Text; DataTasks.lk_note = tbNotes.Text;
                            this.Close();
                        }
                    }
                }
            } // end of if Lowongan Pekerjaan statement
        } // end of EditData Method

        private void History(string pesan)
        {
            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                if (lblKategori.Text == "Event")
                {
                    var query = (from data in db.Events where data.Name == nama select data).FirstOrDefault();
                    skill = query.Minat;
                } // end of Event statement

                else if (lblKategori.Text == "Lomba")
                {
                    var query = (from data in db.Lomba where data.Name == nama select data).FirstOrDefault();
                    skill = query.Minat;
                } // end of Lomba statement

                else if (lblKategori.Text=="Lowongan Pekerjaan")
                {
                    var query = (from data in db.Loker where data.Name == nama select data).FirstOrDefault();
                    skill = query.Minat;
                } // end of Lowongan Pekerjaan statement

                //
                // Menambah kegiatan yang sudah selesai ke table Skill sesuai minat/kategori
                //

                if (skill == "Desain")
                {
                    SkillDesign skill = new SkillDesign
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.Desain.Add(skill);
                    db.SaveChanges();
                } // end of skill Desain statement

                else if (skill == "Bisnis")
                {
                    SkillBisnis skill = new SkillBisnis
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.Bisnis.Add(skill);
                    db.SaveChanges();
                } // end of skill Bisnis statement

                else if (skill == "IT")
                {
                    SkillIT skill = new SkillIT
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.IT.Add(skill);
                    db.SaveChanges();
                } // end of skill IT statement

                else if (skill == "Jurnalisme")
                {
                    SkillJurnalisme history = new SkillJurnalisme
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.Jurnalisme.Add(history);
                    db.SaveChanges();
                } // end of skill Jurnalisme statement

                else if (skill == "Riset")
                {
                    SkillRiset history = new SkillRiset
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.Riset.Add(history);
                    db.SaveChanges();
                } // end of skill Riset statement

                else if (skill == "Umum")
                {
                    SkillUmum history = new SkillUmum
                    {
                        Id = Data.user_id,
                        History = nama,
                        Achievements = "",
                    };
                    db.Umum.Add(history);
                    db.SaveChanges();
                } // end of skill Umum statement
            } // end of accessing database

            MessageBox.Show("Selamat! Anda telah menyelesaikan salah satu kegiatan yang tersedia " +
                "di Hai! Produktif. Jangan lupa klik \"" + pesan + "\" kegiatan lainnya " +
                "agar hari-hari mu selalu produktif!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Data.selesai = true;
            this.Close();
        }
    }
}

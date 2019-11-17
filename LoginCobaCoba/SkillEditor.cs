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
    public partial class SkillEditor : Form
    {
        public string Kategori, historyValue, achievementsValue;

        public SkillEditor(string kategori)
        {
            InitializeComponent();
            Kategori = kategori;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((rtbKegiatan.Text == "") && (rtbPenghargaan.Text == ""))
                MessageBox.Show("Kedua box tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else // Kedua box tidak kosong. Dapat melakukan perubahan ke database
            {
                using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
                {
                    // Menambahkan History dan Achievements pengguna ke database
                    if (Kategori == "DESAIN")
                    {
                        SkillDesign skill = new SkillDesign
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.Desain.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori DESAIN

                    else if (Kategori == "IT")
                    {
                        SkillIT skill = new SkillIT
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.IT.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori IT

                    else if (Kategori == "RISET")
                    {
                        SkillRiset skill = new SkillRiset
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.Riset.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori RISET

                    else if (Kategori == "UMUM")
                    {
                        SkillUmum skill = new SkillUmum
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.Umum.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori UMUM

                    else if (Kategori == "JURNALISME")
                    {
                        SkillJurnalisme skill = new SkillJurnalisme
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.Jurnalisme.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori JURNALISME

                    else if (Kategori == "BISNIS")
                    {
                        SkillBisnis skill = new SkillBisnis
                        {
                            Id = Data.user_id,
                            History = rtbKegiatan.Text,
                            Achievements = rtbPenghargaan.Text,
                        };
                        db.Bisnis.Add(skill);
                        db.SaveChanges();
                    } // end of Kategori BISNIS
                } // end of using database
                MessageBox.Show("Data berhasil ditambahkan!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Data data = new Data();
                data.Resume(Kategori);
                this.Close();
            }
        } // end of btnAdd_Click

        private void rtbKegiatan_Enter(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void rtbKegiatan_Leave(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void rtbPenghargaan_Enter(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void rtbPenghargaan_Leave(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

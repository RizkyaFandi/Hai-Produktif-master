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
    public partial class ProfileEditor : Form
    {
        public ProfileEditor()
        {
            InitializeComponent();

            // Menampilkan data user sebelumnya
            textBox1.Text = Data.first_name;
            textBox3.Text = Data.last_name;
            textBox2.Text = Data.Phone;
            textBox4.Text = Data.Email;
        }

        //
        // Pengubahan warna dan/atau pengubahan teks jika teks kosong ketika textbox aktif/non-aktif
        //

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = Data.first_name;
            }
            textBox1.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            textBox3.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = Data.last_name;
            }
            textBox3.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = Data.Phone;
            }
            textBox2.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            textBox4.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = Data.Email;
            }
            textBox4.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        // Keluar dari form ProfileEditor tanpa perubahan informasi
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Memproses data pengubahan yang di-input user
        private void BtnSave_Click(object sender, EventArgs e)
        {
            long nomor = 0;
            Boolean progress = true;

            // Pengecekan isi textbox
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Informasi tidak boleh ada yang kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cek apakah format nomor telepon sudah benar
                try
                {
                    nomor = long.Parse(textBox2.Text);
                }

                catch (FormatException)
                {
                    MessageBox.Show($"Nomor hanya boleh mengandung angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = false;
                }

                // Cek apakah format E-mail sudah benar
                try
                {
                    var addr = new System.Net.Mail.MailAddress(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Format E-mail tidak benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progress = false;
                }

                // Memulai proses edit jika semua format pengisian sudah benar
                if (progress == true)
                {
                    Data data = new Data();
                    using (var db = new DBModel())
                    {
                        var profil = db.Akun.SingleOrDefault(k => k.Uname == Data.uname);
                        var ex = db.Experience.SingleOrDefault(k => k.Akun == Data.uname);
                        profil.First_Name = textBox1.Text;
                        profil.Last_Name = textBox3.Text;
                        profil.Phone = textBox2.Text;
                        profil.Email = textBox4.Text;
                        db.SaveChanges();
                        var query = (from akun in db.Akun where akun.Uname == Data.uname select akun).FirstOrDefault();
                        data.dataProfil(query.First_Name, query.Last_Name, query.Email, (query.Id).ToString(), query.Phone, query.Uname);
                    }
                    MessageBox.Show("Pergantian data berhasil!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    Profile propil = new Profile();
                    Home home = new Home();
                    propil.Visible = false;
                    home.ShowDialog();
                }
            }
        }
    }
}

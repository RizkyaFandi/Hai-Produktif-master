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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // Menambahkan item ke database
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                long nomor = 0;
                string password = "";
                Boolean progress = true;

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

                // Cek verifikasi password apakah sudah sama
                if (textBox7.Text == textBox6.Text)
                    password = textBox7.Text;
                else
                {
                    MessageBox.Show("Verifikasi password tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // mencegah username yang sama di database
                using (var db = new DBModel())
                {
                    var query = (from akun in db.Akun where akun.Uname == textBox5.Text select akun).FirstOrDefault();
                    if(query != null)
                    {
                        MessageBox.Show("Username sudah pernah digunakan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progress = false;
                    }
                }

                // Menambah data dan membuka form Login
                if (progress==true)
                {
                    TambahData(nomor, password);
                    this.Visible = false;
                    Login login = new Login();
                    login.ShowDialog();
                }

                // Me-reset form register untuk diisi ulang
                else
                {
                    this.Close();
                    Register register = new Register();
                    register.ShowDialog();
                }
            } // end of input data
            else
                MessageBox.Show("Informasi tidak boleh ada yang kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Kembali ke form Login
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.ShowDialog();
        }

        // Menambahkan data register ke database
        private void TambahData(long Nomor, string Passsword)
        {
            using (var db = new DBModel())
            {
                Akun newAkun = new Akun
                {
                    First_Name = textBox1.Text,
                    Last_Name = textBox3.Text,
                    Phone = "0" + Nomor.ToString(),
                    Email = textBox4.Text,
                    Uname = textBox5.Text,
                    Pass = Passsword,
                };
                db.Akun.Add(newAkun);
                db.SaveChanges();
            }

            using (var db = new DBModel())
            {
                Experience newexperience = new Experience
                {
                    Akun = textBox5.Text,
                    Lomba1 = "",
                    Lomba2 = "",
                    Lomba3 = "",
                    Event1 = "",
                    Event2 = "",
                    Event3 = "",
                    Loker1 = "",
                    Loker2 = "",
                    Loker3 = "",
                    ApplyLoker1 = "",
                    ApplyLoker2 = "",
                    ApplyLoker3 = "",
                };
                db.Experience.Add(newexperience);
                db.SaveChanges();
            }

            using (var db = new DBModel())
            {
                for (int i = 0; i < 3; i++)
                {
                    Notes note = new Notes
                    {
                        Akun = textBox5.Text,
                        NameEvent = "-",
                        StatusEvent = "-",
                        NoteEvent = "-",
                        NameLoker = "-",
                        StatusLoker = "-",
                        NoteLoker = "-",
                        NameLomba = "-",
                        ProgressLomba = "-",
                        NoteLomba = "-",
                    };
                    db.Notes.Add(note);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Register Berhasil!", "Notifikasi register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        //
        // Method-method yang berfungi mengubah teks dan warna teks ketika textbox aktif
        //
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "First Name";
                textBox1.ForeColor = ColorTranslator.FromHtml("#797D7F");
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Last Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Last Name";
                textBox3.ForeColor = ColorTranslator.FromHtml("#797D7F");
            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "08xxxxxxxxxx")
            {
                textBox2.Text = "";
                textBox2.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "08xxxxxxxxxx";
                textBox2.ForeColor = ColorTranslator.FromHtml("#797D7F");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Email;
using GemBox.Email.Smtp;


namespace LoginCobaCoba
{
    public partial class VerifEmail : Form
    {
        private string pass, namaakun; // atribut class
        public VerifEmail()
        {
            InitializeComponent();
        }

        // Memproses username yang diinput
        private void RoundButton1_Click(object sender, EventArgs e)
        {
            using (var db = new DBModel())
            {
                var query = (from akun in db.Akun where akun.Uname == textBox1.Text select akun).FirstOrDefault();
                if(query==null)
                {
                    MessageBox.Show("Username tidak ditemukan"); // Akan muncul pesan ini jika username tidak ada
                }

                // Jika username ada, data password dan nama pertama akan diambil dan aplikasi akan mengirimkan password ke e-mail yang dimasukkan
                else
                {
                    pass = query.Pass;
                    namaakun = query.First_Name;
                    EmailSender();
                }
            }
        }

        //
        // Mengubah warna garis ketika textbox diatasnya aktif
        //

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#272727");
        }

        // Kembali ke menu Login
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
        }

        // Mengirimkan E-mail
        private void EmailSender()
        {
            // Menggunakan NuGet Package untuk mengakses API dari GemBox.Email
            ComponentInfo.SetLicense("FREE-LIMITED-KEY"); // lisensi gratis maksimal 50 pengiriman

            // Menetapkan pengirim dan penerima
            MailMessage message = new MailMessage(
                new MailAddress("hai.produktif.app@gmail.com", "Hai Produktif"), // pengirim
                new MailAddress(textBox2.Text, "")); // penerima

            // Menambahkan subjek dan isi pesan
            message.Subject = "Lupa Password";
            message.BodyText = "Hai " + namaakun + ",\nDemi keamanan akun, ingatlah selalu password Anda dan gantilah secara berkala, password Anda adalah:\n\n" + "\"" + pass + "\"";

            // Membuat SMTP Client baru dan mengirim E-mail
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Connect();
                    smtp.Authenticate("hai.produktif.app@gmail.com", "1234567890io");
                    smtp.SendMessage(message);
                }

                MessageBox.Show("Password telah dikirimkan ke E-mail Anda!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Pengiriman berhasil
                Login login = new Login();
                this.Visible = false;
                login.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Pengiriman gagal, mohon periksa koneksi internet Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Pesan ini muncul jika user tidak terkoneksi ke internet
            }
        }
    }
}

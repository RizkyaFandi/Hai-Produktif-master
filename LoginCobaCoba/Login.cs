using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCobaCoba
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Menutup aplikasi
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Mengubah warna teks atau objek jika aktif atau ditunjuk cursor

        private void UnameBox_Enter(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void UnameBox_Leave(object sender, EventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            garis2.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void roundButton1_MouseHover(object sender, EventArgs e)
        {
            roundButton1.BackColor = ColorTranslator.FromHtml("#303030");
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void lupapass_MouseHover(object sender, EventArgs e)
        {
            lupapass.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void lupapass_MouseLeave(object sender, EventArgs e)
        {
            lupapass.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#797D7F");
        }

        // Mencari data user berdasarkan username jika password benar
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (unameBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Masukkan username dan password terlebih dahulu!", "Informasi Login kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new DBModel())
                {
                    var query = (from akun in db.Akun where akun.Uname == unameBox.Text select akun).FirstOrDefault();
                    if (query == null) //check if query null
                    {
                        MessageBox.Show("Data tidak ada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        unameBox.Text = "";
                        passBox.Text = "";
                    }
                    else if ((query.Uname == unameBox.Text) && (query.Pass == passBox.Text)) // masih error di sini buat login. coba pakai try except
                    {
                        Data data = new Data();
                        data.dataProfil(query.First_Name, query.Last_Name, query.Email, (query.Id).ToString(), query.Phone, query.Uname);
                        this.Visible = false;       
                        Home dashboard = new Home();
                        dashboard.ShowDialog();
                    }
                    else if ((query.Uname == unameBox.Text) && (query.Pass != passBox.Text))
                    {
                        MessageBox.Show("Password yang dimasukkan salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passBox.Text = "";
                    }
                }
            }
        }

        // Membuka form Register jika user ingin membuat akun baru
        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            Register register = new Register();
            register.ShowDialog();
        }

        // Membuka form VerifEmail jika user lupa dengan passwordnya
        private void Lupapass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VerifEmail verif = new VerifEmail();
            verif.ShowDialog();
        }
    }
}
    
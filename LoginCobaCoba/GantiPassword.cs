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
    public partial class GantiPassword : Form
    {
        public GantiPassword()
        {
            InitializeComponent();
        }

        // Kembali ke form Profile
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profil = new Profile();
            profil.ShowDialog();
        }

        // Mengganti password
        private void roundButton1_Click(object sender, EventArgs e)
        {
            using (var db = new DBModel())
            {
                var query = (from akun in db.Akun where akun.Uname == Data.uname select akun).FirstOrDefault();

                // Mengecek apakah textbox sudah diisi dengan benar
                if (textBox1.Text != query.Pass)
                {
                    MessageBox.Show("Password lama yang dimasukkan salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Kolom password baru harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Password baru yang dimasukkan tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = ""; textBox3.Text = "";
                }

                // Jika pengisian benar, password di database Akun akan diubah
                else
                {
                    MessageBox.Show("Password berhasil diubah!", "Infomasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    query.Pass = textBox2.Text;
                    this.Visible = false;
                    Profile profil = new Profile();
                    profil.ShowDialog();
                }
            }
        }
    }
}

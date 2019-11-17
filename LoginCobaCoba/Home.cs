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
    public partial class Home : Form
    {
        FormLomba formLomba = new FormLomba();
        FormEvent formEvent = new FormEvent();
        LowonganKerja loker = new LowonganKerja();

        public Home()
        {
            InitializeComponent();

            // Menyiapkan data user dan cek apakah kegiatan sudah diambil user
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            button8.Text = formLomba.IsExist(label8.Text);
            button9.Text = formEvent.IsExist(label17.Text);
            button10.Text = loker.IsExist(label11.Text);
        }

        private void close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        // Keluar dari aplikasi jika button quit di-klik
        private void button12_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Membuka daftar task yang bisa diambil jika Load More di-klik
        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadMore load = new LoadMore();
            load.ShowDialog();
        }

        // Me-restart aplikasi jika user ingin log out
        private void button11_Click(object sender, EventArgs e)
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

        DataTasks data = new DataTasks();

        //
        // Membuka form kegiatan sesuai judul kegiatan yang di-klik
        //

        private void label8_Click(object sender, EventArgs e)
        {
            data.Lomba(label8.Text);
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            data.Event(label17.Text);
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            data.Loker(label11.Text);
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        // Membuka profile user dengan form Profile
        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        //
        // Mengubah mode "add to task" dan "remove from task" ketika di-klik
        //
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = formLomba.Tasks(button8.Text, lblUser.Text, label8.Text);
            data.Experience(lblUser.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = formEvent.Tasks(button9.Text, lblUser.Text, label17.Text);
            data.Experience(lblUser.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = loker.Tasks(button10.Text, lblUser.Text, label11.Text);
            data.Experience(lblUser.Text);
        }

        private void btCari_Click(object sender, EventArgs e)
        {
            if ((dtpDari.Value >= dtpSampai.Value) || (cbKegiatan.Text == "" || cbMinat.Text == ""))
            {
                if (dtpDari.Value >= dtpSampai.Value)
                    MessageBox.Show("Rentang tanggal awal harus kurang dari rentang tanggal kedua!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cbKegiatan.Text == "" || cbMinat.Text == "")
                    MessageBox.Show("Pilih kegiatan dan minat yang dicari!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hasilPencarian.Text = "hasil pencarian:";

                int background = 1;

                flpSearch.Controls.Clear(); //to remove all controls
                flpSearch.Size = new Size(583, 250);

                using (var db = new DBModel())
                {
                    var qLomba = from search in db.Lomba where (DateTime.Compare(search.Deadline, dtpDari.Value) >= 0 && search.Minat == cbMinat.Text) select search;
                    var qLoker = from search in db.Loker where (DateTime.Compare(search.Published, dtpDari.Value) >= 0 && search.Minat == cbMinat.Text) select search;
                    var qEvent = from search in db.Events where (DateTime.Compare(search.Date, dtpDari.Value) >= 0 && search.Minat == cbMinat.Text) select search;

                    if (cbKegiatan.Text == "Lomba")
                    {
                        if (!qLomba.Any())
                        {
                            flpSearch.Size = new Size(583, 1);
                            hasilPencarian.Text += " tidak ditemukan!";
                        }
                        else
                        {
                            foreach (var item in qLomba)
                            {
                                Panel panels = new Panel();
                                panels = Desc((item.Published).ToShortDateString(), item.Name, "lomba", ref background);
                                flpSearch.Controls.Add(panels);
                            }
                        }
                    }
                    else if (cbKegiatan.Text == "Lowongan Pekerjaan")
                    {
                        if (!qLoker.Any())
                        {
                            flpSearch.Size = new Size(583, 1);
                            hasilPencarian.Text += " tidak ditemukan!";
                        }
                        else
                        {
                            foreach (var item in qLoker)
                            {
                                Panel panels = new Panel();
                                panels = Desc((item.Published).ToShortDateString(), item.Name, "lowongan kerja", ref background);
                                flpSearch.Controls.Add(panels);
                            }
                        } 
                    }
                    else if (cbKegiatan.Text == "Event")
                    {
                        if (!qEvent.Any())
                        {
                            flpSearch.Size = new Size(583, 1);
                            hasilPencarian.Text += " tidak ditemukan!";
                        }
                        else
                        {
                            foreach (var item in qEvent)
                            {
                                Panel panels = new Panel();
                                panels = Desc((item.Date).ToShortDateString(), item.Name, "event", ref background);
                                flpSearch.Controls.Add(panels);
                            }
                        }
                    }
                }
            }
        }

        public Panel Desc(string tanggal, string judul, string kategori, ref int ind_background)
        {
            Panel pnl = new Panel();
            pnl.Margin = new Padding (18, 0, 0, 0);
            pnl.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));

            Label lblTgl = new Label(); //tanggal
            lblTgl.AutoSize = true;
            lblTgl.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            lblTgl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            lblTgl.ForeColor = Color.White;
            lblTgl.Location = new Point(15, 165);
            lblTgl.Name = "tanggal";
            lblTgl.Size = new Size(69, 15);
            lblTgl.Text = tanggal;
            pnl.Controls.Add(lblTgl); 

            Label lblJdl = new Label(); //judul 
            lblJdl.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            lblJdl.Cursor = Cursors.Hand;
            lblJdl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblJdl.ForeColor = Color.White;
            lblJdl.Location = new Point(15, 130);
            lblJdl.Name = "judul";
            lblJdl.Size = new Size(126, 35);
            lblJdl.Text = judul;
            lblJdl.Click += (sender, EventArgs) => { lblJdl_Click(sender, EventArgs, judul); };
            pnl.Controls.Add(lblJdl); 

            Label lblKtg = new Label(); //kategori
            lblKtg.AutoSize = true;
            lblKtg.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            lblKtg.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            lblKtg.ForeColor = Color.White;
            lblKtg.Location = new Point(16, 116);
            lblKtg.Name = "kategori";
            lblKtg.Size = new Size(40, 13);
            lblKtg.Text = kategori;
            pnl.Controls.Add(lblKtg); 

            Panel pnlBack = new Panel(); //background
            pnlBack.BackColor = Color.Brown;
            pnlBack.Location = new Point(0, 0);
            pnlBack.Name = "background";
            pnlBack.Size = new Size(155, 100);

            if (ind_background == 1) pnlBack.BackgroundImage = global::LoginCobaCoba.Properties.Resources.BACK1;
            else if (ind_background == 2) pnlBack.BackgroundImage = global::LoginCobaCoba.Properties.Resources.BACK2;
            else if (ind_background == 3)
            {
                pnlBack.BackgroundImage = global::LoginCobaCoba.Properties.Resources.BACK3;
                ind_background = 0;
            }
            ind_background++;

            pnl.Controls.Add(pnlBack); 

            pnl.Name = "panel";
            pnl.Size = new Size(155, 230);
            return pnl;
        }

        void lblJdl_Click(object sender, EventArgs e, string judul)
        {
            Button btn = sender as Button;

            if (cbKegiatan.Text == "Event")
            {
                data.Event(judul);
                FormEvent agenda = new FormEvent();
                this.Visible = false;
                agenda.ShowDialog();
            }
            else if (cbKegiatan.Text == "Lowongan Pekerjaan")
            {
                data.Loker(judul);
                LowonganKerja agenda = new LowonganKerja();
                this.Visible = false;
                agenda.ShowDialog();
            }
            else if (cbKegiatan.Text == "Lomba")
            {
                data.Lomba(judul);
                FormLomba agenda = new FormLomba();
                this.Visible = false;
                agenda.ShowDialog();
            }
        }

        private void cbKegiatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMinat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDari_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSampai_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

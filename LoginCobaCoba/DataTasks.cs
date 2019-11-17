using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCobaCoba
{
    class DataTasks : Data
    {
        public static string e_name, e_authdate, e_desc, e_date, e_status, e_note; //data FormEvent
        public static string l_name, l_authdate, l_desc, l_deadline, l_contact, l_progress, l_note; //data FormLomba
        public static string lk_name, lk_authdate, lk_desc, lk_criteria, lk_status, lk_dateapplied, lk_note; //data FormLoker

        // method seperti Event, Lomba, dan Loker dibuat public agar mudah diakses di form lain

        public void Event(string eventName)
        {
            // Mengganti informasi terkait Event yang sedang dibuka
            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                var query = (from events in db.Events where events.Name == eventName select events).FirstOrDefault();
                e_name = query.Name;

                // mengubah tanggal menjadi tanggal yang pendek (tanggal, bulan, tahun)
                string temp = (query.Published).ToString();
                temp = DateTime.Parse(temp).ToString("dd/MM/yyyy");

                e_authdate = "Oleh: " + query.Auth + " (" + temp + ")";
                e_desc = query.Desc;
                e_date = (query.Date).ToShortDateString();

                // memeriksa apakah pengguna sudah mengambil Event yang sedang dibuka
                var catatan =
                    (from catat in db.Notes
                     where ((catat.Akun == uname) && (e_name == catat.NameEvent))
                     select catat).FirstOrDefault();

                if (catatan == null)
                {
                    e_status = "-"; e_note = "-";
                }
                else // pengguna telah pernah mengambil Event 
                {
                    e_status = catatan.StatusEvent; e_note = catatan.NoteEvent;
                }
            }
        } // end of Event method

        public void Lomba(string lombaName)
        {
            // Mengganti informasi terkait Lomba yang sedang dibuka
            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                var query = (from lomba in db.Lomba where lomba.Name == lombaName select lomba).FirstOrDefault();
                l_name = query.Name;

                // mengubah tanggal menjadi tanggal yang pendek (tanggal, bulan, tahun)
                string temp = (query.Published).ToString();
                temp = DateTime.Parse(temp).ToString("dd/MM/yyyy");

                l_authdate = "Oleh: " + query.Auth + " (" + temp + ")";
                l_desc = query.Desc;
                l_deadline = (query.Deadline).ToShortDateString();
                l_contact = query.CP;

                // memeriksa apakah pengguna sudah mengambil Lomba yang sedang dibuka
                var catatan =
                    (from catat in db.Notes
                     where ((catat.Akun == uname) && (catat.NameLomba == l_name))
                     select catat).FirstOrDefault();

                if (catatan == null)
                {
                    l_progress = "-"; l_note = "-";
                }
                else // pengguna telah pernah mengambil Lomba. Menampilkan catatan kecil terkait lomba tersebut
                {
                    l_progress = catatan.ProgressLomba + "%"; l_note = catatan.NoteLomba;
                }
            }
        } // end of Lomba method

        public void Loker(string lokerName)
        {
            // Mengganti informasi terkait Lowongan Pekerjaan yang sedang dibuka
            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                var query = (from loker in db.Loker where loker.Name == lokerName select loker).FirstOrDefault();
                lk_name = query.Name;

                // mengubah tanggal menjadi tanggal yang pendek (tanggal, bulan, tahun)
                string temp = (query.Published).ToString();
                temp = DateTime.Parse(temp).ToString("dd/MM/yyyy");

                lk_authdate = "Oleh: " + query.Auth + " (" + temp + ")";
                lk_desc = query.Desc;
                lk_criteria = query.Criteria;

                // memeriksa apakah pengguna sudah mengambil Lowongan Pekerjaan yang sedang dibuka
                var catatan =
                    (from catat in db.Notes
                     where ((catat.Akun == uname) && (catat.NameLoker == lk_name))
                     select catat).FirstOrDefault();

                if (catatan == null)
                {
                    lk_status = "-"; lk_note = "-";
                }
                else // pengguna telah pernah mengambil Loker. Menampilkan catatan kecil terkait lomba tersebut
                {
                    lk_status = catatan.StatusLoker; lk_note = catatan.NoteLoker;
                }

                // menampilkan jam ketika pengguna mengambil Lowongan pekerjaan
                var qApply = (from apply in db.Experience where apply.Akun == uname select apply).FirstOrDefault();
                if (qApply.Loker3 == lokerName) lk_dateapplied = qApply.ApplyLoker3;
                else if (qApply.Loker2 == lokerName) lk_dateapplied = qApply.ApplyLoker2;
                else if (qApply.Loker1 == lokerName) lk_dateapplied = qApply.ApplyLoker1;
                else lk_dateapplied = "-";
            }
        } // end of Loker Method
    }
}

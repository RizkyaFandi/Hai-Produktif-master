using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCobaCoba
{
    class Data
    {
        //variabel yang diset public static agar mudah diakses di form lain

        public static string first_name, last_name, uname, user_id, Phone, Email;  
        public static string ex_event1, ex_event2, ex_event3, ex_loker1, ex_loker2, ex_loker3, ex_lomba1, ex_lomba2, ex_lomba3, ex_applyLoker1, ex_applyLoker2, ex_applyLoker3; //data Experience
        public static string rsm_kategori, rsm_history, rsm_going, rsm_achievements; //data SkillResume
        public static int rsm_total, rsm_going_count; //data SkillResume
        public static bool selesai;
        private int total;

        // Method seperti dataProfil dibuat public agar mudah diakses di form lain
        // Method CheckData dan AlterData cukup dapat diakses di Data.cs, sehingga menggunakan access private

        public void dataProfil(string fName, string lName, string email, string id, string phone, string uName)
        {
            // method dataProfil bertujuan untuk menyimpan sementara informasi dari user yang sedang login
            first_name = fName;
            last_name = lName;
            uname = uName;
            Email = email;
            Phone = phone;
            user_id = id;
        } // end of dataProfil method

        public void Experience(string AkunName)
        {
            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                // mengakses tabel Experience yang berisikan kegiatan-kegiatan yang
                // sedang diambil oleh pengguna 
                var query =
                    (from experience in db.Experience
                     where experience.Akun == AkunName
                     select experience).FirstOrDefault();

                ex_event1 = query.Event1;
                ex_event2 = query.Event2;
                ex_event3 = query.Event3;

                ex_loker1 = query.Loker1;
                ex_loker2 = query.Loker2;
                ex_loker3 = query.Loker3;

                ex_lomba1 = query.Lomba1;
                ex_lomba2 = query.Lomba2;
                ex_lomba3 = query.Lomba3;

                ex_applyLoker1 = query.ApplyLoker1;
                ex_applyLoker2 = query.ApplyLoker2;
                ex_applyLoker3 = query.ApplyLoker3;
            }
        } // end of Experience method

        public void Resume(string kategori)
        {
            // method yang menyiapkan data untuk ditampilkan di form SkillResume
            rsm_kategori = kategori;    // kategori kegiatan yang sedang dibuka
            rsm_going = "";             // resume On-Going pengguna
            rsm_history = "";           // resume History kegiatan pengguna
            rsm_achievements = "";      // resume Achievements pengguna
            rsm_going_count = 0;        // variabel untuk menghitung jumlah On-Going pengguna
            total = 0;                  // Total History, Achievements, On-Going

            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                if (kategori == "DESAIN")
                {
                    var query = db.Desain.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori Desain 
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori DESAIN

                else if (kategori == "IT")
                {
                    var query = db.IT.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori IT
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori IT

                else if (kategori == "RISET")
                {
                    var query = db.Riset.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori Riset
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori RISET

                else if (kategori == "UMUM")
                {
                    var query = db.Umum.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori Umum
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori UMUM

                else if (kategori == "JURNALISME")
                {
                    var query = db.Jurnalisme.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori Jurnalisme
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori JURNALISME

                else if (kategori == "BISNIS")
                {
                    var query = db.Bisnis.Select(x => new { x.Id, x.History, x.Achievements }).
                        Where(x => x.Id == user_id).ToList();

                    if (!query.Any()) CheckData(); // memberitahu bahwa data dengan kategori tidak ada
                                                   // dan beralih ke method CheckData
                    else
                    {
                        // menambahkan riwayat kegiatan dan penghargaan pengguna kategori Bisnis
                        foreach (var item in query)
                        {
                            if ((item.History != null) && (item.History != ""))
                            {
                                rsm_history += "- " + item.History + "\n";
                                total++;
                            }
                            if ((item.Achievements != null) && (item.Achievements != ""))
                            {
                                rsm_achievements += "- " + item.Achievements + "\n";
                                total++;
                            }
                        }
                        // beralih ke method CheckData
                        CheckData();
                    }

                    // beralih ke method AlterData dan memberi parameter kategori dengan huruf dikecilkan 
                    AlterData(kategori.ToLower());
                } // end of kategori BISNIS
            }
        } // end of Resume method

        private void CheckData()
        {
            string temp = rsm_kategori.ToLower();
            if (temp == "it") temp = temp.ToUpper(); // agar penulisan IT konsisten huruf besar

            // menandakan tidak pernah menyelesaikan kegiatan di kategori tertentu
            if (rsm_history == "") rsm_history = "Tidak terdapat riwayat kegiatan di bidang " + temp;

            // menandakan tidak pernah mendapat pengahrgaan di kategori tertentu
            if (rsm_achievements == "") rsm_achievements = "Tidak ada prestasi di bidang " + temp;
        } // end of CheckData method

        private void AlterData(string tempKategori)
        {
            char[] temp = tempKategori.ToCharArray(); // membuat char temporary, persiapan mengubah huruf pertama jadi kapital
            temp[0] = (char)(temp[0] - 'a' + 'A'); // convert huruf pertama jadi kapital
            string kategori = new string(temp);

            using (var db = new DBModel()) // menggunakan model DBModel untuk akses database
            {
                var qExp = (from exp in db.Experience where (exp.Id).ToString() == user_id select exp).FirstOrDefault();
                var qEvent = from data in db.Events select data;  // akses tabel Event
                var qLomba = from data in db.Lomba select data;   // akses tabel Lomba  
                var qLoker = from data in db.Loker select data;   // akses tabel Loker

                foreach (var item in qLomba)
                {
                    // Menambahkan value ke rsm_going dengan syarat kegiatan yang dibuka sedang diambil
                    // dan menghitung jumlah On-Going 
                    if ((qExp.Lomba1 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Lomba2 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Lomba3 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                }

                foreach (var item in qEvent)
                {
                    // Menambahkan value ke rsm_going dengan syarat kegiatan yang dibuka sedang diambil
                    // dan menghitung jumlah On-Going 
                    if ((qExp.Event1 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Event2 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Event3 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                }

                foreach (var item in qLoker)
                {
                    // Menambahkan value ke rsm_going dengan syarat kegiatan yang dibuka sedang diambil
                    // dan menghitung jumlah On-Going 
                    if ((qExp.Loker1 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Loker2 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                    if ((qExp.Loker3 == item.Name) && (item.Minat == kategori))
                    {
                        rsm_going += "- " + item.Name + "\n";
                        rsm_going_count++;
                    }
                }
            }

            if (rsm_going_count == 0) rsm_going = "Tidak ada kegiatan yang berlangsung"; // Pengguna tidak mengambil kegiatan
            total += rsm_going_count;
            rsm_total = total;
        } // end of AlterData method
    }
}

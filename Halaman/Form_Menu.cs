using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_Menu : Form
    {
        string nama;
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlKaryawan.Height = pnlKaryawan.MinimumSize.Height;
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            if (pnlKaryawan.Height == pnlKaryawan.MaximumSize.Height)
            {
                pnlKaryawan.Height = pnlKaryawan.MinimumSize.Height;
            }
            else if (pnlKaryawan.Height == pnlKaryawan.MinimumSize.Height)
            {
                pnlKaryawan.Height = pnlKaryawan.MaximumSize.Height;
            }
        }

        private void btnMasterKaryawan_Click(object sender, EventArgs e)
        {
            Form_Master_Karyawan kry = new Form_Master_Karyawan();
            kry.TopLevel = false;
            pnlContainer.Controls.Add(kry);
            kry.BringToFront();
            kry.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Close();
        }
        private void UpdateDateTimeLabel()
        {
            DateTime currentDateTime = DateTime.Now;
            labelDateTime.Text = currentDateTime.ToString("dd MMMM yyyy HH:mm:ss"); // Format tanggal dan waktu sesuai kebutuhan Anda
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }
        private void GenerateNama()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 Nama FROM Riwayat_Login ORDER BY Id_Login DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        nama = reader.GetString(0);
                    }
                }
                reader.Close();
            }
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            GenerateNama();
            lblNama.Text = nama;
            UpdateDateTimeLabel(); // Panggil method untuk pertama kali
            Timer timer = new Timer();
            timer.Interval = 1000; // Interval dalam milidetik (1000ms = 1 detik)
            timer.Tick += dateTimer_Tick;
            timer.Start(); // Mulai Timer untuk memperbarui label setiap detik
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Form_View_Manager mng = new Form_View_Manager();
            mng.TopLevel = false;
            pnlContainer.Controls.Add(mng);
            mng.BringToFront();
            mng.Show();
        }

        private void btnApoteker_Click(object sender, EventArgs e)
        {
            Form_View_Apoteker apt = new Form_View_Apoteker();
            apt.TopLevel = false;
            pnlContainer.Controls.Add(apt);
            apt.BringToFront();
            apt.Show();
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            Form_View_Dokter dok = new Form_View_Dokter();
            dok.TopLevel = false;
            pnlContainer.Controls.Add(dok);
            dok.BringToFront();
            dok.Show();
        }

        private void btnResepsionis_Click(object sender, EventArgs e)
        {
            Form_View_Resepsionis rsp = new Form_View_Resepsionis();
            rsp.TopLevel = false;
            pnlContainer.Controls.Add(rsp);
            rsp.BringToFront();
            rsp.Show();
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            if (pnlObat.Height == pnlObat.MaximumSize.Height)
            {
                pnlObat.Height = pnlObat.MinimumSize.Height;
            }
            else if (pnlObat.Height == pnlObat.MinimumSize.Height)
            {
                pnlObat.Height = pnlObat.MaximumSize.Height;
            }
        }
        private void btnMasterObat_Click(object sender, EventArgs e)
        {
            Form_Master_Obat obt = new Form_Master_Obat();
            obt.TopLevel = false;
            pnlContainer.Controls.Add(obt);
            obt.BringToFront();
            obt.Show();
        }
        private void btnViewObat_Click(object sender, EventArgs e)
        {
            Form_View_Obat obt = new Form_View_Obat();
            obt.TopLevel = false;
            pnlContainer.Controls.Add(obt);
            obt.BringToFront();
            obt.Show();
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            if (pnlPasien.Height == pnlPasien.MaximumSize.Height)
            {
                pnlPasien.Height = pnlPasien.MinimumSize.Height;
            }
            else if (pnlPasien.Height == pnlPasien.MinimumSize.Height)
            {
                pnlPasien.Height = pnlPasien.MaximumSize.Height;
            }
        }

        private void btnViewPasien_Click(object sender, EventArgs e)
        {
            Form_View_Pasien pas = new Form_View_Pasien();
            pas.TopLevel = false;
            pnlContainer.Controls.Add(pas);
            pas.BringToFront();
            pas.Show();
        }

        private void btnMasterPasien_Click(object sender, EventArgs e)
        {
            Form_Master_Pasien pas = new Form_Master_Pasien();
            pas.TopLevel = false;
            pnlContainer.Controls.Add(pas);
            pas.BringToFront();
            pas.Show();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            Form_Pengaturan_Akun acc = new Form_Pengaturan_Akun();
            acc.TopLevel = false;
            pnlContainer.Controls.Add(acc);
            acc.BringToFront();
            acc.Show();
        }
    }
}

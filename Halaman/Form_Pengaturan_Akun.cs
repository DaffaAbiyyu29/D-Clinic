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
    public partial class Form_Pengaturan_Akun : Form
    {
        Msg_Box mBox = new Msg_Box();

        string lastLogin;
        public Form_Pengaturan_Akun()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txEmail.Clear();
            txTelp.Clear();
            txUsername.Clear();
            txPassword.Clear();
            txPassword2.Clear();
        }
        private void resetIcon()
        {
            //Mereset Warna Icon menjadi warna putih
            imgID.Image = Properties.Resources.white_id_card;
            imgNama.Image = Properties.Resources.white_name;
            imgTelp.Image = Properties.Resources.white_telephone;
            imgEmail.Image = Properties.Resources.white_email;
            imgUsername.Image = Properties.Resources.white_user;
            imgPassword.Image = Properties.Resources.white_pass;
            imgPassword2.Image = Properties.Resources.white_pass;
        }
        private void GenerateLastLogin()
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
                        lastLogin = reader.GetString(0);
                    }
                }
                reader.Close();
            }
        }
        private void GenerateKaryawan()
        {
            GenerateLastLogin();
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT * FROM Karyawan WHERE Nama = @nama";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nama", lastLogin);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        string id = reader.GetString(0);
                        string nama = reader.GetString(1);
                        string email = reader.GetString(2);
                        string telp = reader.GetString(3);
                        string username = reader.GetString(4);
                        string password = reader.GetString(5);

                        txID.Text = id;
                        txNama.Text = nama;
                        txEmail.Text = email;
                        txTelp.Text = telp;
                        txUsername.Text = username;
                        txPassword.Text = password;
                        txPassword2.Text = password;
                    }
                }
                reader.Close();
            }
        }

        private void Form_Pengaturan_Akun_Load(object sender, EventArgs e)
        {
            GenerateKaryawan();
        }
        private void UpdateKaryawan()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Karyawan update = context.Karyawans.FirstOrDefault(data => data.Id_Karyawan == txID.Text);
                    update.Nama = txNama.Text;
                    update.Email = txEmail.Text;
                    update.Telp = txTelp.Text;
                    update.Username = txUsername.Text;
                    update.Password = txPassword.Text;

                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Memperbarui Akun";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    GenerateKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txPassword.Text.Equals(txPassword2.Text))
            {
                UpdateKaryawan();
            }
            else
            {
                mBox.Show();
                string loginSession = "Password Tidak Cocok";
                mBox.text1.Text = "Password Tidak Cocok!";
                mBox.session.Text = loginSession;
                mBox.WarningMessage();
            }
        }
        private void HapusKaryawan()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Karyawan delete = context.Karyawans.FirstOrDefault(data => data.Id_Karyawan == txID.Text);

                    context.Karyawans.DeleteOnSubmit(delete);
                    context.SubmitChanges();

                    this.Hide();
                    mBox.text1.Text = "Akun Terhapus";
                    mBox.session.Text = "Akun Terhapus";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusKaryawan();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            GenerateKaryawan();
        }
    }
}

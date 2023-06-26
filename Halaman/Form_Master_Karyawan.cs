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
    public partial class Form_Master_Karyawan : Form
    {
        Msg_Box mBox = new Msg_Box();

        string IDKaryawan, IDDokter, IDResepsionis, IDApoteker, IDManager;
        int lastID;
        public Form_Master_Karyawan()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariID.Clear();
            txCariNama.Clear();
            txCariUsername.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            txEmail.Clear();
            txTelp.Clear();
            txUsername.Clear();
            txPassword.Clear();
            cbJabatan.SelectedIndex = 0;
        }
        private void resetIcon()
        {
            //Mereset Warna Icon menjadi warna putih
            imgSearchID.Image = Properties.Resources.white_id_card;
            imgSearchNama.Image = Properties.Resources.white_name;
            imgSearchUsername.Image = Properties.Resources.white_user;
            imgID.Image = Properties.Resources.white_id_card;
            imgNama.Image = Properties.Resources.white_name;
            imgTelp.Image = Properties.Resources.white_telephone;
            imgEmail.Image = Properties.Resources.white_email;
            imgUsername.Image = Properties.Resources.white_user;
            imgPassword.Image = Properties.Resources.white_pass;
            imgJabatan.Image = Properties.Resources.white_role;
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txEmail.Enabled = false;
            txTelp.Enabled = false;
            txUsername.Enabled = false;
            txPassword.Enabled = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
        }
        private void txCariID_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            imgSearchID.Image = Properties.Resources.green_id_card;
            txCariNama.PlaceholderForeColor = Color.White;
            txCariUsername.PlaceholderForeColor = Color.White;
        }

        private void txCariNama_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            imgSearchNama.Image = Properties.Resources.green_name;
            txCariID.PlaceholderForeColor = Color.White;
            txCariUsername.PlaceholderForeColor = Color.White;
        }

        private void txCariUsername_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            imgSearchUsername.Image = Properties.Resources.green_user;
            txCariID.PlaceholderForeColor = Color.White;
            txCariNama.PlaceholderForeColor = Color.White;
        }

        private void txID_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgID.Image = Properties.Resources.green_id_card;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
            txPassword.PlaceholderForeColor = Color.White;
        }

        private void txNama_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgNama.Image = Properties.Resources.green_name;

            txID.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
            txPassword.PlaceholderForeColor = Color.White;
        }

        private void txTelp_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgTelp.Image = Properties.Resources.green_telephone;

            txID.PlaceholderForeColor = Color.White;
            txNama.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
            txPassword.PlaceholderForeColor = Color.White;
        }

        private void txEmail_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgEmail.Image = Properties.Resources.green_email;

            txID.PlaceholderForeColor = Color.White;
            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
            txPassword.PlaceholderForeColor = Color.White;
        }

        private void txUsername_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgUsername.Image = Properties.Resources.green_user;

            txID.PlaceholderForeColor = Color.White;
            txNama.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txPassword.PlaceholderForeColor = Color.White;
        }

        private void txPassword_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgPassword.Image = Properties.Resources.green_pass;

            txID.PlaceholderForeColor = Color.White;
            txNama.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
        }

        private void cbJabatan_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgJabatan.Image = Properties.Resources.green_suitcase;

            txID.PlaceholderForeColor = Color.White;
            txNama.PlaceholderForeColor = Color.White;
            txEmail.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txUsername.PlaceholderForeColor = Color.White;
        }
        private void GenerateIDKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Karyawan, 3) AS ID FROM Karyawan ORDER BY Id_Karyawan DESC";

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
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                IDKaryawan = string.Format("KRY{0:D3}", lastID + 1);
                txID.Text = IDKaryawan;
            }
        }
        private void GenerateIDDokter()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Dokter, 3) AS ID FROM Dokter ORDER BY Id_Dokter DESC";

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
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                IDDokter = string.Format("DOK{0:D3}", lastID + 1);
            }
        }
        private void GenerateIDManager()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Manager, 3) AS ID FROM Manager ORDER BY Id_Manager DESC";

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
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                IDManager = string.Format("MGR{0:D3}", lastID + 1);
            }
        }
        private void GenerateIDResepsionis()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Resepsionis, 3) AS ID FROM Resepsionis ORDER BY Id_Resepsionis DESC";

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
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                IDResepsionis = string.Format("RSP{0:D3}", lastID + 1);
            }
        }
        private void GenerateIDApoteker()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Apoteker, 3) AS ID FROM Apoteker ORDER BY Id_Apoteker DESC";

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
                        lastID = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    lastID = 0;
                }
                reader.Close();

                IDApoteker = string.Format("APT{0:D3}", lastID + 1);
            }
        }
        private void TambahKaryawan()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Karyawan input = new Karyawan();
                    input.Id_Karyawan = txID.Text;
                    input.Nama = txNama.Text;
                    input.Email = txEmail.Text;
                    input.Telp = txTelp.Text;
                    input.Username = txUsername.Text;
                    input.Password = txPassword.Text;
                    input.Jabatan = cbJabatan.Text;

                    context.Karyawans.InsertOnSubmit(input);
                    context.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);
            }
        }
        private void TambahDokter()
        {
            GenerateIDDokter();
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Dokter input = new Dokter();
                    input.Id_Dokter = IDDokter;
                    input.Id_Karyawan = txID.Text;

                    context.Dokters.InsertOnSubmit(input);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menambahkan Dokter :D";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TambahManager()
        {
            GenerateIDManager();
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Manager input = new Manager();
                    input.Id_Manager = IDManager;
                    input.Id_Karyawan = txID.Text;

                    context.Managers.InsertOnSubmit(input);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menambahkan Manager :D";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TambahResepsionis()
        {
            GenerateIDResepsionis();
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Resepsioni input = new Resepsioni();
                    input.Id_Resepsionis = IDResepsionis;
                    input.Id_Karyawan = txID.Text;

                    context.Resepsionis.InsertOnSubmit(input);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menambahkan Resepsionis :D";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TambahApoteker()
        {
            GenerateIDApoteker();
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Apoteker input = new Apoteker();
                    input.Id_Apoteker = IDApoteker;
                    input.Id_Karyawan = txID.Text;

                    context.Apotekers.InsertOnSubmit(input);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menambahkan Apoteker :D";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error : " + ex, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cariKaryawan()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "";
            if (txCariID.Text.Length != 0)
            {
                query = "SELECT * FROM Karyawan WHERE Id_Karyawan = '" + txCariID.Text + "'";
            }
            else if (txCariNama.Text.Length != 0)
            {
                query = "SELECT * FROM Karyawan WHERE Nama = '" + txCariNama.Text + "'";
            }
            else if (txCariUsername.Text.Length != 0)
            {
                query = "SELECT * FROM Karyawan WHERE Username = '" + txCariUsername.Text + "'";
            }

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
                        string id = reader.GetString(0);
                        string nama = reader.GetString(1);
                        string email = reader.GetString(2);
                        string telp = reader.GetString(3);
                        string username = reader.GetString(4);
                        string password = reader.GetString(5);
                        string jabatan = reader.GetString(6);

                        txID.Enabled = false;
                        txNama.Enabled = true;
                        txEmail.Enabled = true;
                        txTelp.Enabled = true;
                        cbJabatan.Enabled = true;
                        btnHapus.Enabled = true;
                        btnUpdate.Enabled = true;

                        txID.Text = id;
                        txNama.Text = nama;
                        txEmail.Text = email;
                        txTelp.Text = telp;
                        txUsername.Text = username;
                        txPassword.Text = password;
                        cbJabatan.Text = jabatan;
                    }
                }
                else
                {
                    mBox.text1.Text = "Karyawan " + txCariID.Text + txCariNama.Text + txCariUsername.Text + " Tidak Ditemukan, Silakan Cari Karyawan Kembali!";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    mBox.WarningMessage();
                }
                reader.Close();
            }
        }
        private void btnCari_Click(object sender, EventArgs e)
        {

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

                    mBox.text1.Text = "Berhasil Menghapus Karyawan";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusKaryawan();
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
                    update.Jabatan = cbJabatan.Text;

                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Memperbarui Karyawan";
                    mBox.session.Text = "Karyawan";
                    mBox.Show();
                    clearText();
                    resetIcon();
                    disablePropherties();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateKaryawan();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbJabatan.SelectedIndex != 0)
            {
                TambahKaryawan();
                if (cbJabatan.Text == "Manager")
                {
                    TambahManager();
                }
                else if (cbJabatan.Text == "Resepsionis")
                {
                    TambahResepsionis();
                }
                else if (cbJabatan.Text == "Apoteker")
                {
                    TambahApoteker();
                }
                else if (cbJabatan.Text == "Dokter")
                {
                    TambahDokter();
                }
            }
        }

        private void txTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txCariID.Text != "" || txCariNama.Text != "" || txCariUsername.Text != "")
            {
                cariKaryawan();
            }
            else
            {
                mBox.text1.Text = "Masukkan Karyawan Yang Ingin Diubah!";
                mBox.session.Text = "Karyawan";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
            GenerateIDKaryawan();
            txNama.Enabled = true;
            txEmail.Enabled = true;
            txTelp.Enabled = true;
            txUsername.Enabled = true;
            txPassword.Enabled = true;
            cbJabatan.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
        }

        private void Form_Master_Karyawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.dClinicDataSet.Karyawan);

        }
    }
}

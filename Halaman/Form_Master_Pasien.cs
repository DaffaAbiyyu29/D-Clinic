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

namespace D_Clinic
{
    public partial class Form_Master_Pasien : Form
    {
        Msg_Box mBox = new Msg_Box();

        string IDPasien;
        int lastID;
        public Form_Master_Pasien()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            txCariID.Clear();
            txCariNama.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            cbGender.SelectedIndex = 0;
            cbGolDarah.SelectedIndex = 0;
            txTelp.Clear();
            txAlamat.Clear();
            txKeluhan.Clear();
        }
        private void resetIcon()
        {
            //Mereset Warna Icon menjadi warna putih
            imgSearchID.Image = Properties.Resources.white_id_card;
            imgSearchNama.Image = Properties.Resources.white_name;
            imgID.Image = Properties.Resources.white_id_card;
            imgNama.Image = Properties.Resources.white_name;
            imgGender.Image = Properties.Resources.white_gender;
            imgGolDarah.Image = Properties.Resources.white_blood;
            imgTelp.Image = Properties.Resources.white_telephone;
            imgAlamat.Image = Properties.Resources.white_location;
            imgKeluhan.Image = Properties.Resources.white_keluhan;
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            cbGender.Enabled = false;
            cbGolDarah.Enabled = false;
            txTelp.Enabled = false;
            txAlamat.Enabled = false;
            txKeluhan.Enabled = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
        }

        private void txCariID_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
            imgSearchID.Image = Properties.Resources.green_id_card;
            txCariNama.PlaceholderForeColor = Color.White;
        }

        private void txCariNama_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
            imgSearchNama.Image = Properties.Resources.green_name;
            txCariID.PlaceholderForeColor = Color.White;
        }

        private void txNama_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgNama.Image = Properties.Resources.green_name;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }

        private void cbGender_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgGender.Image = Properties.Resources.green_gender;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }

        private void cbGolDarah_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgGolDarah.Image = Properties.Resources.green_blood;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }

        private void txTelp_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgTelp.Image = Properties.Resources.green_telephone;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }

        private void txAlamat_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgAlamat.Image = Properties.Resources.green_location;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }

        private void txKeluhan_MouseClick(object sender, MouseEventArgs e)
        {
            resetIcon();
            imgKeluhan.Image = Properties.Resources.green_keluhan;

            txNama.PlaceholderForeColor = Color.White;
            txTelp.PlaceholderForeColor = Color.White;
            txAlamat.DisabledState.BorderColor = Color.White;
            txKeluhan.PlaceholderForeColor = Color.White;
        }
        private void GenerateIDPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Pasien, 3) AS ID FROM Pasien ORDER BY Id_Pasien DESC";

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

                IDPasien = string.Format("PAS{0:D3}", lastID + 1);
                txID.Text = IDPasien;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
            GenerateIDPasien();
            txNama.Enabled = true;
            cbGender.Enabled = true;
            cbGolDarah.Enabled = true;
            txAlamat.Enabled = true;
            txTelp.Enabled = true;
            txAlamat.Enabled = true;
            txKeluhan.Enabled = true;
            btnSimpan.Enabled = true;
        }
        private void HapusPasien()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Pasien delete = context.Pasiens.FirstOrDefault(data => data.Id_Pasien == txID.Text);

                    context.Pasiens.DeleteOnSubmit(delete);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menghapus Pasien";
                    mBox.session.Text = "Pasien";
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
                this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusPasien();
        }

        private void Form_Master_Pasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.Pasien' table. You can move, or remove it, as needed.
            this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);

        }
        private void UpdatePasien()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Pasien update = context.Pasiens.FirstOrDefault(data => data.Id_Pasien == txID.Text);
                    update.Nama = txNama.Text;
                    update.Jenis_Kelamin = cbGender.Text;
                    update.Golongan_Darah = cbGolDarah.Text;
                    update.Telp = txTelp.Text;
                    update.Alamat = txAlamat.Text;
                    update.Keluhan = txKeluhan.Text;

                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Memperbarui Pasien";
                    mBox.session.Text = "Pasien";
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
                this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePasien();
        }
        private void TambahPasien()
        {

            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Pasien input = new Pasien();
                    input.Id_Pasien = txID.Text;
                    input.Nama = txNama.Text;
                    input.Jenis_Kelamin = cbGender.Text;
                    input.Golongan_Darah = cbGolDarah.Text;
                    input.Telp = txTelp.Text;
                    input.Alamat = txAlamat.Text;
                    input.Keluhan = txKeluhan.Text;

                    context.Pasiens.InsertOnSubmit(input);
                    context.SubmitChanges();

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
            finally
            {
                this.pasienTableAdapter.Fill(this.dClinicDataSet.Pasien);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex != 0 && cbGolDarah.SelectedIndex != 0)
            {
                TambahPasien();
                mBox.text1.Text = "Berhasil Menambahkan Pasien :D";
                mBox.session.Text = "Pasien";
                mBox.Show();
            }
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
        }
        private void cariPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "";
            if (txCariID.Text.Length != 0)
            {
                query = "SELECT * FROM Pasien WHERE Id_Pasien = '" + txCariID.Text + "'";
            }
            else if (txCariNama.Text.Length != 0)
            {
                query = "SELECT * FROM Pasien WHERE Nama = '" + txCariNama.Text + "'";
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
                        string gender = reader.GetString(2);
                        string gol_darah = reader.GetString(3);
                        string telp = reader.GetString(4);
                        string alamat = reader.GetString(5);
                        string keluhan = reader.GetString(6);

                        txID.Enabled = false;
                        txNama.Enabled = true;
                        cbGender.Enabled = true;
                        cbGolDarah.Enabled = true;
                        txTelp.Enabled = true;
                        txAlamat.Enabled = true;
                        txKeluhan.Enabled = true;
                        btnHapus.Enabled = true;
                        btnUpdate.Enabled = true;

                        txID.Text = id;
                        txNama.Text = nama;
                        cbGender.Text = gender;
                        cbGolDarah.Text = gol_darah;
                        txTelp.Text = telp;
                        txAlamat.Text = alamat;
                        txKeluhan.Text = keluhan;
                    }
                }
                else
                {
                    mBox.text1.Text = "Pasien " + txCariID.Text + txCariNama.Text + " Tidak Ditemukan, Silakan Cari Pasien Kembali!";
                    mBox.session.Text = "Pasien";
                    mBox.Show();
                    mBox.WarningMessage();
                }
                reader.Close();
            }
        }
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txCariID.Text != "" || txCariNama.Text != "")
            {
                cariPasien();
            }
            else
            {
                mBox.text1.Text = "Masukkan Pasien Yang Ingin Diubah!";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void txTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

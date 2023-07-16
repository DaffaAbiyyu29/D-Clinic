using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace D_Clinic
{
    public partial class Form_Master_Pasien : Form
    {
        Msg_Box mBox = new Msg_Box();
        string gender, status = "";

        string IDPasien;
        int lastID;
        public Form_Master_Pasien()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            //Mengkosongkan Semua Textbox dan Combobox
            DateTime currentDateTime = DateTime.Now;
            dtpTglLahir.Value = currentDateTime;
            txCariPasien.Clear();
            txID.Enabled = true;
            txID.Clear();
            txNama.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            cbGolDarah.SelectedIndex = -1;
            cbGolDarah.ForeColor = Color.White;
            txTelp.Clear();
            txAlamat.Clear();
        }
        
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            dtpTglLahir.Enabled = false;
            rbLaki.Enabled = false;
            rbPerempuan.Enabled = false;
            cbGolDarah.Enabled = false;
            txTelp.Enabled = false;
            txAlamat.Enabled = false;
            btnUpdate.Enabled = false;
            btnNonAktif.Visible = false;
            btnAktif.Visible = false;
            btnSimpan.Enabled = false;
        }
        private void Gambar()
        {
            if (txCariPasien.Text.Length != 0)
            {
                txCariPasien.IconLeft = Properties.Resources.green_magnifier;
            }
            else
            {
                txCariPasien.IconLeft = Properties.Resources.white_magnifier;
            }

            if (txID.Text.Length != 0)
            {
                txID.IconLeft = Properties.Resources.green_id_card;
            }
            else
            {
                txID.IconLeft = Properties.Resources.white_id_card;
            }

            if (txNama.Text.Length != 0)
            {
                txNama.IconLeft = Properties.Resources.green_name;
            }
            else
            {
                txNama.IconLeft = Properties.Resources.white_name;
            }

            if (txTelp.Text.Length != 0)
            {
                txTelp.IconLeft = Properties.Resources.green_telephone;
            }
            else
            {
                txTelp.IconLeft = Properties.Resources.white_telephone;
            }

            if (txAlamat.Text.Length != 0)
            {
                txAlamat.IconLeft = Properties.Resources.green_location;
            }
            else
            {
                txAlamat.IconLeft = Properties.Resources.white_location;
            }

            if (rbLaki.Checked || rbPerempuan.Checked)
            {
                imgGender.Image = Properties.Resources.green_gender;
            }
            else
            {
                imgGender.Image = Properties.Resources.white_gender;
            }
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
            disablePropherties();
            GenerateIDPasien();
            txNama.Enabled = true;
            dtpTglLahir.Enabled = true;
            rbLaki.Enabled = true;
            rbPerempuan.Enabled = true;
            cbGolDarah.Enabled = true;
            txAlamat.Enabled = true;
            txTelp.Enabled = true;
            txAlamat.Enabled = true;
            btnSimpan.Enabled = true;
            Gambar();
        }
        private void NonAktifPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_DisablePasien", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_Pasien", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Non-Aktifkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Non-Aktifkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnNonAktif_Click(object sender, EventArgs e)
        {
            NonAktifPasien();
        }
        private void AktifPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand disable = new SqlCommand("sp_EnablePasien", connection);
            disable.CommandType = CommandType.StoredProcedure;
            disable.Parameters.AddWithValue("Id_Pasien", txID.Text);

            try
            {
                connection.Open();
                disable.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Aktifkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Aktifkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktifPasien();
        }
        private void UpdatePasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdatePasien", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Pasien", txID.Text);
            update.Parameters.AddWithValue("Nama", txNama.Text);
            update.Parameters.AddWithValue("Tgl_Lahir", dtpTglLahir.Value);
            if (rbLaki.Checked)
            {
                gender = "Laki-Laki";
            }
            else if (rbPerempuan.Checked)
            {
                gender = "Perempuan";
            }
            update.Parameters.AddWithValue("Jenis_Kelamin", gender);
            update.Parameters.AddWithValue("Golongan_Darah", cbGolDarah.Text);
            update.Parameters.AddWithValue("Telp", txTelp.Text);
            update.Parameters.AddWithValue("Alamat", txAlamat.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();

                mBox.text1.Text = "Berhasil Memperbarui Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
                Gambar();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Memperbarui Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txTelp.Text.Length < 12)
            {
                mBox.text1.Text = "Nomor Telepon Tidak Valid";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.WarningMessage();
            }
            else
            {
                UpdatePasien();
            }
        }
        private void TambahPasien()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertPasien", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Pasien", txID.Text);
            insert.Parameters.AddWithValue("Nama", txNama.Text);
            insert.Parameters.AddWithValue("Tgl_Lahir", dtpTglLahir.Value);
            if (rbLaki.Checked)
            {
                gender = "Laki-Laki";
            }
            else if (rbPerempuan.Checked)
            {
                gender = "Perempuan";
            }
            insert.Parameters.AddWithValue("Jenis_Kelamin", gender);
            insert.Parameters.AddWithValue("Golongan_Darah", cbGolDarah.Text);
            insert.Parameters.AddWithValue("Telp", txTelp.Text);
            insert.Parameters.AddWithValue("Alamat", txAlamat.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                mBox.text1.Text = "Berhasil Menambahkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.SuccessMessage();
                clearText();
                disablePropherties();
            }
            catch (Exception)
            {
                mBox.text1.Text = "Gagal Menambahkan Pasien";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.ErrorMessage();
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txNama.Text.Length != 0 || rbLaki.Checked == true || rbPerempuan.Checked == true || cbGolDarah.SelectedIndex != -1 || txTelp.Text.Length != 0 || txAlamat.Text.Length != 0)
            {
                if (cbGolDarah.SelectedIndex != -1)
                {
                    if (txTelp.Text.Length < 12)
                    {
                        mBox.text1.Text = "Nomor Telepon Tidak Valid";
                        mBox.session.Text = "Pasien";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    else
                    {
                        TambahPasien();
                    }
                }
            }
            else
            {
                mBox.text1.Text = "Masukkan Semua Data!";
                mBox.session.Text = "Pasien";
                mBox.Show();
                mBox.WarningMessage();
            }
            Gambar();
        }
        
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            disablePropherties();
            Gambar();
        }
        private void cariPasien()
        {

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            SqlConnection connection = new SqlConnection(connectionString);
            string data = txCariPasien.Text;
            if (txCariPasien.Text.Length != 0)
            {
                SqlCommand search = new SqlCommand("sp_SearchPasien", connection);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.AddWithValue("Data", data);
                search.Parameters.AddWithValue("Status", status);

                try
                {
                    connection.Open();
                    search.ExecuteNonQuery();
                    SqlDataReader reader = search.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Ambil nilai-nilai kolom dari reader
                            string id = reader.GetString(0);
                            string nama = reader.GetString(1);
                            DateTime tglLahir = reader.GetDateTime(2);
                            string gender = reader.GetString(3);
                            string gol_darah = reader.GetString(4);
                            string telp = reader.GetString(5);
                            string alamat = reader.GetString(6);
                            status = reader.GetString(7);

                            txID.Enabled = false;
                            txNama.Enabled = true;
                            dtpTglLahir.Enabled = true;
                            rbLaki.Enabled = true;
                            rbPerempuan.Enabled = true;
                            cbGolDarah.Enabled = true;
                            txTelp.Enabled = true;
                            txAlamat.Enabled = true;
                            btnUpdate.Enabled = true;
                            if (status == "Non-Aktif")
                            {
                                btnAktif.Visible = true;
                                btnNonAktif.Visible = false;
                            }
                            else if (status == "Aktif")
                            {
                                btnAktif.Visible = false;
                                btnNonAktif.Visible = true;
                            }

                            txID.Text = id;
                            txNama.Text = nama;
                            dtpTglLahir.Value = tglLahir;
                            if(gender == "Laki-Laki")
                            {
                                rbLaki.Checked = true;
                            } else if(gender == "Perempuan")
                            {
                                rbPerempuan.Checked = true;
                            }
                            cbGolDarah.Text = gol_darah;
                            txTelp.Text = telp;
                            txAlamat.Text = alamat;
                        }
                    }
                    else
                    {
                        mBox.text1.Text = "Pasien " + txCariPasien.Text + " Tidak Ditemukan, Silakan Cari Pasien Kembali!";
                        mBox.session.Text = "Pasien";
                        mBox.Show();
                        mBox.WarningMessage();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    mBox.text1.Text = "Gagal Mencari Pasien";
                    mBox.session.Text = "Pasien";
                    mBox.Show();
                    mBox.ErrorMessage();
                }
            }
        }
       
        private void Gambar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gambar();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = false;
            if (txCariPasien.Text != "")
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
            Gambar();
        }
        public static bool ValidasiEmail(string email)
        {
            // Pola regular expression untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Lakukan validasi menggunakan Regex.IsMatch
            return Regex.IsMatch(email, pattern);
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gambar();
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Gambar_Click(object sender, EventArgs e)
        {
            Gambar();
        }

        private void cbGolDarah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGolDarah.SelectedIndex != -1)
            {
                imgGolDarah.Image = Properties.Resources.green_blood;
                lblGolDarah.Visible = false;
                cbGolDarah.ForeColor = Color.FromArgb(131, 235, 97);

            }
            else
            {
                imgGolDarah.Image = Properties.Resources.white_blood;
                lblGolDarah.Visible = true;
            }
        }

        private void Form_Master_Pasien_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            dtpTglLahir.Value = currentDateTime;
        }
    }
}

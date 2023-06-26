using D_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Obat : Form
    {
        Msg_Box mBox = new Msg_Box();

        string IDObat;
        int lastID;
        public Form_Master_Obat()
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
            txMerk.Clear();
            cbKemasan.SelectedIndex = 0;
            txEfek.Clear();
            txHargaBeli.Clear();
            txHargaJual.Clear();
            dtpKadaluarsa.Value.ToLocalTime();
            txStok.Clear();
        }
        private void resetIcon()
        {
            //Mereset Warna Icon menjadi warna putih
            imgSearchID.Image = Properties.Resources.white_id_card;
            imgSearchNama.Image = Properties.Resources.white_name;
            imgID.Image = Properties.Resources.white_id_card;
            imgNama.Image = Properties.Resources.white_name;
            imgMerk.Image = Properties.Resources.white_merk;
            imgKemasan.Image = Properties.Resources.white_kemasan;
            imgEfek.Image = Properties.Resources.white_efek;
            imgHargaBeli.Image = Properties.Resources.white_harga;
            imgHargaJual.Image = Properties.Resources.white_harga;
            imgTanggal.Image = Properties.Resources.white_cal;
            imgStok.Image = Properties.Resources.white_stok;
        }
        private void disablePropherties()
        {
            txID.Enabled = false;
            txNama.Enabled = false;
            txMerk.Enabled = false;
            cbKemasan.Enabled = false;
            txEfek.Enabled = false;
            txHargaBeli.Enabled = false;
            txHargaJual.Enabled = false;
            dtpKadaluarsa.Checked = false;
            txStok.Enabled = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
        }
        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void txMerk_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgMerk.Image = Properties.Resources.green_merk;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void cbKemasan_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgKemasan.Image = Properties.Resources.green_kemasan;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void txEfek_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgEfek.Image = Properties.Resources.green_efek;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void txHarga_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgHargaBeli.Image = Properties.Resources.green_harga;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void dtpKadaluarsa_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgTanggal.Image = Properties.Resources.green_cal;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }

        private void txStok_Click(object sender, EventArgs e)
        {
            resetIcon();
            imgStok.Image = Properties.Resources.green_stok;

            txNama.PlaceholderForeColor = Color.White;
            txMerk.PlaceholderForeColor = Color.White;
            txEfek.PlaceholderForeColor = Color.White;
            txHargaJual.PlaceholderForeColor = Color.White;
            txHargaJual.DisabledState.BorderColor = Color.White;
            txStok.PlaceholderForeColor = Color.White;
        }
        private void GenerateIDObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT TOP 1 RIGHT(Id_Obat, 3) AS ID FROM Obat ORDER BY Id_Obat DESC";

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

                IDObat = string.Format("OBT{0:D3}", lastID + 1);
                txID.Text = IDObat;
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
            GenerateIDObat();
            txNama.Enabled = true;
            txMerk.Enabled = true;
            cbKemasan.Enabled = true;
            txEfek.Enabled = true;
            dtpKadaluarsa.Checked = true;
            txHargaBeli.Enabled = true;
            txStok.Enabled = true;
            btnSimpan.Enabled = true;
        }
        private void HapusObat()
        {
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Obat delete = context.Obats.FirstOrDefault(data => data.Id_Obat == txID.Text);

                    context.Obats.DeleteOnSubmit(delete);
                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Menghapus Obat";
                    mBox.session.Text = "Obat";
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
                this.obatTableAdapter.Fill(this.dClinicDataSet.Obat);
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusObat();
        }
        private void UpdateObat()
        {
            dtpKadaluarsa.Format = DateTimePickerFormat.Custom;
            dtpKadaluarsa.CustomFormat = "dd/MM/yy";
            string unformatHargaBeli = txHargaBeli.Text.Replace(".", "");
            string unformatHargaJual = txHargaJual.Text.Replace(".", "");
            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Obat update = context.Obats.FirstOrDefault(data => data.Id_Obat == txID.Text);
                    update.Nama = txNama.Text;
                    update.Merk = txMerk.Text;
                    update.Kemasan = cbKemasan.Text;
                    update.Efek = txEfek.Text;
                    update.Harga_Beli = int.Parse(unformatHargaBeli);
                    update.Harga_Jual = int.Parse(unformatHargaJual);
                    update.Tgl_Kadaluarsa = dtpKadaluarsa.Value;
                    update.Stok = int.Parse(txStok.Text);

                    context.SubmitChanges();

                    mBox.text1.Text = "Berhasil Memperbarui Obat";
                    mBox.session.Text = "Obat";
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
                this.obatTableAdapter.Fill(this.dClinicDataSet.Obat);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateObat();
        }
        private void TambahObat()
        {
            dtpKadaluarsa.Format = DateTimePickerFormat.Custom;
            dtpKadaluarsa.CustomFormat = "dd/MM/yy";
            string unformatHargaBeli = txHargaBeli.Text.Replace(".", "");
            string unformatHargaJual = txHargaJual.Text.Replace(".", "");

            try
            {
                using (DClinicDataContext context = new DClinicDataContext())
                {
                    Obat input = new Obat();
                    input.Id_Obat = txID.Text;
                    input.Nama = txNama.Text;
                    input.Merk = txMerk.Text;
                    input.Kemasan = cbKemasan.Text;
                    input.Efek = txEfek.Text;
                    input.Harga_Beli = int.Parse(unformatHargaBeli);
                    input.Harga_Jual = int.Parse(unformatHargaJual);
                    input.Tgl_Kadaluarsa = dtpKadaluarsa.Value;
                    input.Stok = int.Parse(txStok.Text);

                    context.Obats.InsertOnSubmit(input);
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
                this.obatTableAdapter.Fill(this.dClinicDataSet.Obat);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbKemasan.SelectedIndex != 0)
            {
                TambahObat();
                mBox.text1.Text = "Berhasil Menambahkan Obat :D";
                mBox.session.Text = "Obat";
                mBox.Show();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            resetIcon();
            disablePropherties();
        }
        //HARGA JUAL = HARGA BELI + 20%
        private void GenerateHargaJual()
        {
            double persen = 20;
            string unformatHarga = txHargaBeli.Text.Replace(".", "");
            double hargaBeli = double.Parse(unformatHarga);
            double hargaJual = hargaBeli + (hargaBeli * (persen/100));

            string formatHarga = hargaJual.ToString("N0");
            txHargaJual.Text = formatHarga;
        }
        private void Form_Master_Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.Obat' table. You can move, or remove it, as needed.
            this.obatTableAdapter.Fill(this.dClinicDataSet.Obat);

        }
        private void cariObat()
        {
            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "";
            if (txCariID.Text.Length != 0)
            {
                query = "SELECT * FROM Obat WHERE Id_Obat = '" + txCariID.Text + "'";
            }
            else if (txCariNama.Text.Length != 0)
            {
                query = "SELECT * FROM Obat WHERE Nama = '" + txCariNama.Text + "'";
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
                        string merk = reader.GetString(2);
                        string kemasan = reader.GetString(3);
                        string efek = reader.GetString(4);
                        int hargaBeli = (int)reader.GetSqlMoney(5);
                        int hargaJual = (int)reader.GetSqlMoney(6);
                        DateTime tglKadaluarsa = reader.GetDateTime(7);
                        int stok = reader.GetInt32(8);

                        txID.Enabled = false;
                        txNama.Enabled = true;
                        txMerk.Enabled = true;
                        cbKemasan.Enabled = true;
                        txEfek.Enabled = true;
                        txHargaBeli.Enabled = true;
                        dtpKadaluarsa.Enabled = true;
                        txStok.Enabled = true;
                        btnHapus.Enabled = true;
                        btnUpdate.Enabled = true;

                        string formatHargaBeli = hargaBeli.ToString("N0");
                        string formatHargaJual = hargaJual.ToString("N0");
                        txID.Text = id;
                        txNama.Text = nama;
                        txMerk.Text = merk;
                        cbKemasan.Text = kemasan;
                        txEfek.Text = efek;
                        txHargaBeli.Text = formatHargaBeli;
                        txHargaJual.Text = formatHargaJual;
                        dtpKadaluarsa.Value = tglKadaluarsa;
                        txStok.Text = stok.ToString();
                    }
                }
                else
                {
                    mBox.text1.Text = "Obat " + txCariID.Text + txCariNama.Text + " Tidak Ditemukan, Silakan Cari Obat Kembali!";
                    mBox.session.Text = "Obat";
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
                cariObat();
            }
            else
            {
                mBox.text1.Text = "Masukkan Obat Yang Ingin Diubah!";
                mBox.session.Text = "Obat";
                mBox.Show();
                mBox.WarningMessage();
            }
        }

        private void txHargaBeli_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txHargaBeli.Text))
            {
                decimal currencyValue;
                if (decimal.TryParse(txHargaBeli.Text, out currencyValue))
                {
                    // Format nilai mata uang Rupiah
                    txHargaBeli.Text = currencyValue.ToString("N0");
                    txHargaBeli.SelectionStart = txHargaBeli.Text.Length;
                    txHargaBeli.SelectionLength = 0;
                    GenerateHargaJual();
                    imgHargaJual.Image = Properties.Resources.green_harga;
                    txHargaJual.DisabledState.ForeColor = Color.FromArgb(131, 235, 97);
                    txHargaJual.DisabledState.BorderColor = Color.FromArgb(131, 235, 97);
                }
            }
            else
            {
                // Jika input jumlah tidak valid, set total harga menjadi kosong atau nol
                txHargaJual.Text = "";
                imgHargaJual.Image = Properties.Resources.white_harga;
                txHargaJual.DisabledState.ForeColor = Color.White;
                txHargaJual.DisabledState.BorderColor = Color.White;
            }
            txHargaJual.DisabledState.BorderColor = Color.White;
        }
    }
}

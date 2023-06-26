﻿using D_Clinic.Halaman;
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

namespace D_Clinic.Resources
{
    public partial class Msg_Box : Form
    {
        string nama;
        public Msg_Box()
        {
            InitializeComponent();
        }

        private void Msg_Box_Load(object sender, EventArgs e)
        {
            GenerateNama();
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
        private void Masuk()
        {
            Form_Menu menu = new Form_Menu();

            string connectionString = "Integrated Security = False; Data Source = DAFFA; User = sa; Password = daffa; Initial Catalog = DClinic";
            string query = "SELECT Jabatan FROM Karyawan WHERE Nama = '" + nama + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    menu.Show();
                    this.Hide();

                    while (reader.Read())
                    {
                        // Ambil nilai-nilai kolom dari reader
                        string jabatan = reader.GetString(0);

                        menu.lblNama.Text = nama;
                        if (jabatan == "Manager")
                        {
                            menu.btnKaryawan.Visible = true;
                        }
                        else if (jabatan == "Resepsionis")
                        {
                            menu.btnPasien.Visible = true;
                        }
                        else if (jabatan == "Dokter")
                        {

                        }
                        else if (jabatan == "Apoteker")
                        {
                            menu.btnObat.Visible = true;
                        }
                    }
                }
                reader.Close();
            }
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (session.Text == "Login Berhasil")
            {
                Masuk();
            }
            else if (session.Text == "Akses Ditolak")
            {
                Program.CloseAllForms();
            }
            else //if (session.Text == "Obat")
            {
                this.Close();
            }
        }
        public void WarningMessage()
        {
            pnlAtas.FillColor = Color.Gold;
            pnlBawah.FillColor = Color.Gold;
            pnlContainer.BorderColor = Color.Gold;
            text1.ForeColor = Color.Gold;
            btnOkay.ForeColor = Color.Gold;
            btnOkay.BorderColor = Color.Gold;
            btnOkay.HoverState.BorderColor = Color.Gold;
            btnOkay.HoverState.FillColor = Color.Gold;
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
        }
        public void ErrorMessage()
        {
            pnlAtas.FillColor = Color.FromArgb(247, 56, 89);
            pnlBawah.FillColor = Color.FromArgb(247, 56, 89);
            pnlContainer.BorderColor = Color.FromArgb(247, 56, 89);
            text1.ForeColor = Color.FromArgb(247, 56, 89);
            btnOkay.ForeColor = Color.FromArgb(247, 56, 89);
            btnOkay.BorderColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.BorderColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.FillColor = Color.FromArgb(247, 56, 89);
            btnOkay.HoverState.ForeColor = Color.FromArgb(47, 46, 48);
        }
    }
}
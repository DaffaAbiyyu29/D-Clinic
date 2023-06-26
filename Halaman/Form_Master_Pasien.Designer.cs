namespace D_Clinic
{
    partial class Form_Master_Pasien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblPasien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.txNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txTelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txKeluhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCariID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.txCariNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGolDarah = new Guna.UI2.WinForms.Guna2ComboBox();
            this.imgGolDarah = new System.Windows.Forms.PictureBox();
            this.imgGender = new System.Windows.Forms.PictureBox();
            this.imgID = new System.Windows.Forms.PictureBox();
            this.imgNama = new System.Windows.Forms.PictureBox();
            this.imgKeluhan = new System.Windows.Forms.PictureBox();
            this.imgTelp = new System.Windows.Forms.PictureBox();
            this.imgAlamat = new System.Windows.Forms.PictureBox();
            this.imgSearchID = new System.Windows.Forms.PictureBox();
            this.imgSearchNama = new System.Windows.Forms.PictureBox();
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGolDarah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKeluhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlamat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.tblPasien);
            this.guna2GroupBox1.Controls.Add(this.btnTambah);
            this.guna2GroupBox1.Controls.Add(this.btnUbah);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.Controls.Add(this.txCariID);
            this.guna2GroupBox1.Controls.Add(this.btnBatal);
            this.guna2GroupBox1.Controls.Add(this.txCariNama);
            this.guna2GroupBox1.Controls.Add(this.imgSearchID);
            this.guna2GroupBox1.Controls.Add(this.btnCari);
            this.guna2GroupBox1.Controls.Add(this.imgSearchNama);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 134);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(990, 607);
            this.guna2GroupBox1.TabIndex = 36;
            // 
            // tblPasien
            // 
            this.tblPasien.AllowUserToAddRows = false;
            this.tblPasien.AllowUserToDeleteRows = false;
            this.tblPasien.AllowUserToResizeColumns = false;
            this.tblPasien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPasien.AutoGenerateColumns = false;
            this.tblPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblPasien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPasien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tblPasien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tblPasien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPasien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPasien.ColumnHeadersHeight = 40;
            this.tblPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPasienDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.keluhanDataGridViewTextBoxColumn});
            this.tblPasien.DataSource = this.pasienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPasien.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblPasien.Enabled = false;
            this.tblPasien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.Location = new System.Drawing.Point(29, 209);
            this.tblPasien.MultiSelect = false;
            this.tblPasien.Name = "tblPasien";
            this.tblPasien.ReadOnly = true;
            this.tblPasien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPasien.RowHeadersVisible = false;
            this.tblPasien.RowHeadersWidth = 4;
            this.tblPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPasien.RowTemplate.Height = 30;
            this.tblPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPasien.Size = new System.Drawing.Size(537, 315);
            this.tblPasien.TabIndex = 59;
            this.tblPasien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblPasien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblPasien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblPasien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPasien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPasien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPasien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblPasien.ThemeStyle.HeaderStyle.Height = 40;
            this.tblPasien.ThemeStyle.ReadOnly = true;
            this.tblPasien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tblPasien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPasien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblPasien.ThemeStyle.RowsStyle.Height = 30;
            this.tblPasien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblPasien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            // 
            // btnTambah
            // 
            this.btnTambah.Animated = true;
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.BorderRadius = 10;
            this.btnTambah.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTambah.BorderThickness = 2;
            this.btnTambah.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambah.FillColor = System.Drawing.Color.Transparent;
            this.btnTambah.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnTambah.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTambah.Location = new System.Drawing.Point(28, 153);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnTambah.PressedDepth = 50;
            this.btnTambah.Size = new System.Drawing.Size(537, 37);
            this.btnTambah.TabIndex = 54;
            this.btnTambah.Text = "Tambah Pasien";
            this.btnTambah.UseTransparentBackground = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Animated = true;
            this.btnUbah.BackColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUbah.BorderRadius = 10;
            this.btnUbah.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUbah.BorderThickness = 2;
            this.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbah.FillColor = System.Drawing.Color.Transparent;
            this.btnUbah.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUbah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUbah.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUbah.Location = new System.Drawing.Point(390, 76);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnUbah.PressedDepth = 50;
            this.btnUbah.Size = new System.Drawing.Size(187, 37);
            this.btnUbah.TabIndex = 53;
            this.btnUbah.Text = "Ubah Pasien";
            this.btnUbah.UseTransparentBackground = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(589, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 574);
            this.panel1.TabIndex = 56;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.cbGolDarah);
            this.guna2GroupBox2.Controls.Add(this.cbGender);
            this.guna2GroupBox2.Controls.Add(this.btnSimpan);
            this.guna2GroupBox2.Controls.Add(this.btnUpdate);
            this.guna2GroupBox2.Controls.Add(this.txID);
            this.guna2GroupBox2.Controls.Add(this.btnHapus);
            this.guna2GroupBox2.Controls.Add(this.txNama);
            this.guna2GroupBox2.Controls.Add(this.imgGolDarah);
            this.guna2GroupBox2.Controls.Add(this.txTelp);
            this.guna2GroupBox2.Controls.Add(this.imgGender);
            this.guna2GroupBox2.Controls.Add(this.txAlamat);
            this.guna2GroupBox2.Controls.Add(this.txKeluhan);
            this.guna2GroupBox2.Controls.Add(this.imgID);
            this.guna2GroupBox2.Controls.Add(this.imgNama);
            this.guna2GroupBox2.Controls.Add(this.imgKeluhan);
            this.guna2GroupBox2.Controls.Add(this.imgTelp);
            this.guna2GroupBox2.Controls.Add(this.imgAlamat);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Porsche Next TT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(611, 18);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(356, 574);
            this.guna2GroupBox2.TabIndex = 57;
            this.guna2GroupBox2.Text = "Detail Karyawan";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGender.BorderColor = System.Drawing.Color.White;
            this.cbGender.BorderThickness = 2;
            this.cbGender.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGender.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Enabled = false;
            this.cbGender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGender.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGender.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.cbGender.ForeColor = System.Drawing.Color.White;
            this.cbGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Jenis Kelamin",
            "Laki-Laki",
            "Perempuan"});
            this.cbGender.Location = new System.Drawing.Point(60, 145);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(269, 36);
            this.cbGender.StartIndex = 0;
            this.cbGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbGender.TabIndex = 28;
            this.cbGender.Click += new System.EventHandler(this.cbGender_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Animated = true;
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.BorderRadius = 10;
            this.btnSimpan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSimpan.BorderThickness = 2;
            this.btnSimpan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.Enabled = false;
            this.btnSimpan.FillColor = System.Drawing.Color.Transparent;
            this.btnSimpan.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.btnSimpan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnSimpan.Location = new System.Drawing.Point(239, 505);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnSimpan.PressedDepth = 50;
            this.btnSimpan.Size = new System.Drawing.Size(90, 37);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseTransparentBackground = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnUpdate.Location = new System.Drawing.Point(133, 505);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnUpdate.PressedDepth = 50;
            this.btnUpdate.Size = new System.Drawing.Size(90, 37);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txID
            // 
            this.txID.Animated = true;
            this.txID.AutoRoundedCorners = true;
            this.txID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.BorderColor = System.Drawing.Color.White;
            this.txID.BorderRadius = 16;
            this.txID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txID.BorderThickness = 2;
            this.txID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txID.DefaultText = "";
            this.txID.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txID.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.Enabled = false;
            this.txID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txID.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txID.Location = new System.Drawing.Point(60, 39);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Pasien";
            this.txID.SelectedText = "";
            this.txID.Size = new System.Drawing.Size(269, 35);
            this.txID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txID.TabIndex = 21;
            // 
            // btnHapus
            // 
            this.btnHapus.Animated = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapus.BorderRadius = 10;
            this.btnHapus.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnHapus.BorderThickness = 2;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapus.Enabled = false;
            this.btnHapus.FillColor = System.Drawing.Color.Transparent;
            this.btnHapus.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.btnHapus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnHapus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.btnHapus.Location = new System.Drawing.Point(26, 505);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnHapus.PressedDepth = 50;
            this.btnHapus.Size = new System.Drawing.Size(90, 37);
            this.btnHapus.TabIndex = 26;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseTransparentBackground = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txNama
            // 
            this.txNama.Animated = true;
            this.txNama.AutoRoundedCorners = true;
            this.txNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.BorderColor = System.Drawing.Color.White;
            this.txNama.BorderRadius = 16;
            this.txNama.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txNama.BorderThickness = 2;
            this.txNama.Cursor = System.Windows.Forms.Cursors.Default;
            this.txNama.DefaultText = "";
            this.txNama.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.Enabled = false;
            this.txNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txNama.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txNama.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNama.Location = new System.Drawing.Point(60, 92);
            this.txNama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txNama.MaxLength = 30;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.PlaceholderText = "Nama Pasien";
            this.txNama.SelectedText = "";
            this.txNama.Size = new System.Drawing.Size(269, 35);
            this.txNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txNama.TabIndex = 20;
            this.txNama.Click += new System.EventHandler(this.txNama_Click);
            // 
            // txTelp
            // 
            this.txTelp.Animated = true;
            this.txTelp.AutoRoundedCorners = true;
            this.txTelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.BorderColor = System.Drawing.Color.White;
            this.txTelp.BorderRadius = 16;
            this.txTelp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txTelp.BorderThickness = 2;
            this.txTelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.txTelp.DefaultText = "";
            this.txTelp.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txTelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txTelp.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTelp.Enabled = false;
            this.txTelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTelp.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txTelp.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txTelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txTelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTelp.Location = new System.Drawing.Point(60, 253);
            this.txTelp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txTelp.MaxLength = 13;
            this.txTelp.Name = "txTelp";
            this.txTelp.PasswordChar = '\0';
            this.txTelp.PlaceholderForeColor = System.Drawing.Color.White;
            this.txTelp.PlaceholderText = "Telepon";
            this.txTelp.SelectedText = "";
            this.txTelp.Size = new System.Drawing.Size(269, 35);
            this.txTelp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txTelp.TabIndex = 20;
            this.txTelp.Click += new System.EventHandler(this.txTelp_Click);
            this.txTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTelp_KeyPress);
            // 
            // txAlamat
            // 
            this.txAlamat.Animated = true;
            this.txAlamat.AutoRoundedCorners = true;
            this.txAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txAlamat.BorderColor = System.Drawing.Color.White;
            this.txAlamat.BorderRadius = 40;
            this.txAlamat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txAlamat.BorderThickness = 2;
            this.txAlamat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txAlamat.DefaultText = "";
            this.txAlamat.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txAlamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txAlamat.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txAlamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txAlamat.Enabled = false;
            this.txAlamat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txAlamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txAlamat.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txAlamat.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txAlamat.Location = new System.Drawing.Point(60, 306);
            this.txAlamat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txAlamat.MaxLength = 1000;
            this.txAlamat.Multiline = true;
            this.txAlamat.Name = "txAlamat";
            this.txAlamat.PasswordChar = '\0';
            this.txAlamat.PlaceholderForeColor = System.Drawing.Color.White;
            this.txAlamat.PlaceholderText = "Alamat";
            this.txAlamat.SelectedText = "";
            this.txAlamat.Size = new System.Drawing.Size(269, 83);
            this.txAlamat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txAlamat.TabIndex = 20;
            this.txAlamat.Click += new System.EventHandler(this.txAlamat_Click);
            // 
            // txKeluhan
            // 
            this.txKeluhan.Animated = true;
            this.txKeluhan.AutoRoundedCorners = true;
            this.txKeluhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeluhan.BorderColor = System.Drawing.Color.White;
            this.txKeluhan.BorderRadius = 40;
            this.txKeluhan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txKeluhan.BorderThickness = 2;
            this.txKeluhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txKeluhan.DefaultText = "";
            this.txKeluhan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txKeluhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeluhan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txKeluhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeluhan.Enabled = false;
            this.txKeluhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeluhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeluhan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txKeluhan.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txKeluhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txKeluhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txKeluhan.Location = new System.Drawing.Point(60, 399);
            this.txKeluhan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txKeluhan.MaxLength = 1000;
            this.txKeluhan.Multiline = true;
            this.txKeluhan.Name = "txKeluhan";
            this.txKeluhan.PasswordChar = '\0';
            this.txKeluhan.PlaceholderForeColor = System.Drawing.Color.White;
            this.txKeluhan.PlaceholderText = "Keluhan";
            this.txKeluhan.SelectedText = "";
            this.txKeluhan.Size = new System.Drawing.Size(269, 83);
            this.txKeluhan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txKeluhan.TabIndex = 20;
            this.txKeluhan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txKeluhan_MouseClick);
            // 
            // txCariID
            // 
            this.txCariID.Animated = true;
            this.txCariID.AutoRoundedCorners = true;
            this.txCariID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariID.BorderColor = System.Drawing.Color.White;
            this.txCariID.BorderRadius = 16;
            this.txCariID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariID.BorderThickness = 2;
            this.txCariID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCariID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariID.DefaultText = "";
            this.txCariID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariID.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariID.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txCariID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariID.Location = new System.Drawing.Point(64, 16);
            this.txCariID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariID.MaxLength = 7;
            this.txCariID.Name = "txCariID";
            this.txCariID.PasswordChar = '\0';
            this.txCariID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariID.PlaceholderText = "ID Pasien";
            this.txCariID.SelectedText = "";
            this.txCariID.Size = new System.Drawing.Size(306, 35);
            this.txCariID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariID.TabIndex = 47;
            this.txCariID.Click += new System.EventHandler(this.txCariID_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Animated = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnBatal.BorderRadius = 10;
            this.btnBatal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBatal.BorderThickness = 2;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.FillColor = System.Drawing.Color.Transparent;
            this.btnBatal.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnBatal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnBatal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBatal.Location = new System.Drawing.Point(28, 555);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnBatal.PressedDepth = 50;
            this.btnBatal.Size = new System.Drawing.Size(538, 37);
            this.btnBatal.TabIndex = 55;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseTransparentBackground = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txCariNama
            // 
            this.txCariNama.Animated = true;
            this.txCariNama.AutoRoundedCorners = true;
            this.txCariNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariNama.BorderColor = System.Drawing.Color.White;
            this.txCariNama.BorderRadius = 16;
            this.txCariNama.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txCariNama.BorderThickness = 2;
            this.txCariNama.Cursor = System.Windows.Forms.Cursors.Default;
            this.txCariNama.DefaultText = "";
            this.txCariNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCariNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCariNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCariNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txCariNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariNama.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariNama.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.txCariNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txCariNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCariNama.Location = new System.Drawing.Point(64, 76);
            this.txCariNama.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txCariNama.MaxLength = 30;
            this.txCariNama.Name = "txCariNama";
            this.txCariNama.PasswordChar = '\0';
            this.txCariNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txCariNama.PlaceholderText = "Nama Pasien";
            this.txCariNama.SelectedText = "";
            this.txCariNama.Size = new System.Drawing.Size(306, 35);
            this.txCariNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariNama.TabIndex = 48;
            this.txCariNama.Click += new System.EventHandler(this.txCariNama_Click);
            // 
            // btnCari
            // 
            this.btnCari.Animated = true;
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.BorderRadius = 10;
            this.btnCari.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCari.BorderThickness = 2;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.Transparent;
            this.btnCari.Font = new System.Drawing.Font("Porsche Next TT", 13F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCari.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCari.Location = new System.Drawing.Point(390, 16);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.PressedColor = System.Drawing.Color.NavajoWhite;
            this.btnCari.PressedDepth = 50;
            this.btnCari.Size = new System.Drawing.Size(187, 37);
            this.btnCari.TabIndex = 52;
            this.btnCari.Text = "Cari Pasien";
            this.btnCari.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(463, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 95);
            this.label1.TabIndex = 35;
            this.label1.Text = "Pasien";
            // 
            // cbGolDarah
            // 
            this.cbGolDarah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGolDarah.BorderColor = System.Drawing.Color.White;
            this.cbGolDarah.BorderThickness = 2;
            this.cbGolDarah.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbGolDarah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGolDarah.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbGolDarah.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGolDarah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGolDarah.Enabled = false;
            this.cbGolDarah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbGolDarah.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGolDarah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGolDarah.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbGolDarah.Font = new System.Drawing.Font("Porsche Next TT", 16F, System.Drawing.FontStyle.Bold);
            this.cbGolDarah.ForeColor = System.Drawing.Color.White;
            this.cbGolDarah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGolDarah.ItemHeight = 30;
            this.cbGolDarah.Items.AddRange(new object[] {
            "Golongan Darah",
            "A",
            "B",
            "AB",
            "O"});
            this.cbGolDarah.Location = new System.Drawing.Point(60, 199);
            this.cbGolDarah.Margin = new System.Windows.Forms.Padding(2);
            this.cbGolDarah.Name = "cbGolDarah";
            this.cbGolDarah.Size = new System.Drawing.Size(269, 36);
            this.cbGolDarah.StartIndex = 0;
            this.cbGolDarah.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbGolDarah.TabIndex = 28;
            this.cbGolDarah.Click += new System.EventHandler(this.cbGolDarah_Click);
            // 
            // imgGolDarah
            // 
            this.imgGolDarah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgGolDarah.Image = global::D_Clinic.Properties.Resources.white_blood;
            this.imgGolDarah.Location = new System.Drawing.Point(20, 200);
            this.imgGolDarah.Margin = new System.Windows.Forms.Padding(2);
            this.imgGolDarah.Name = "imgGolDarah";
            this.imgGolDarah.Size = new System.Drawing.Size(35, 35);
            this.imgGolDarah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGolDarah.TabIndex = 22;
            this.imgGolDarah.TabStop = false;
            // 
            // imgGender
            // 
            this.imgGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgGender.Image = global::D_Clinic.Properties.Resources.white_gender;
            this.imgGender.Location = new System.Drawing.Point(20, 146);
            this.imgGender.Margin = new System.Windows.Forms.Padding(2);
            this.imgGender.Name = "imgGender";
            this.imgGender.Size = new System.Drawing.Size(35, 35);
            this.imgGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGender.TabIndex = 22;
            this.imgGender.TabStop = false;
            // 
            // imgID
            // 
            this.imgID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgID.Image = global::D_Clinic.Properties.Resources.white_id_card;
            this.imgID.Location = new System.Drawing.Point(20, 39);
            this.imgID.Margin = new System.Windows.Forms.Padding(2);
            this.imgID.Name = "imgID";
            this.imgID.Size = new System.Drawing.Size(35, 35);
            this.imgID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgID.TabIndex = 23;
            this.imgID.TabStop = false;
            // 
            // imgNama
            // 
            this.imgNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgNama.Image = global::D_Clinic.Properties.Resources.white_name;
            this.imgNama.Location = new System.Drawing.Point(20, 92);
            this.imgNama.Margin = new System.Windows.Forms.Padding(2);
            this.imgNama.Name = "imgNama";
            this.imgNama.Size = new System.Drawing.Size(35, 35);
            this.imgNama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNama.TabIndex = 22;
            this.imgNama.TabStop = false;
            // 
            // imgKeluhan
            // 
            this.imgKeluhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgKeluhan.Image = global::D_Clinic.Properties.Resources.white_keluhan;
            this.imgKeluhan.Location = new System.Drawing.Point(20, 399);
            this.imgKeluhan.Margin = new System.Windows.Forms.Padding(2);
            this.imgKeluhan.Name = "imgKeluhan";
            this.imgKeluhan.Size = new System.Drawing.Size(35, 35);
            this.imgKeluhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgKeluhan.TabIndex = 22;
            this.imgKeluhan.TabStop = false;
            // 
            // imgTelp
            // 
            this.imgTelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgTelp.Image = global::D_Clinic.Properties.Resources.white_telephone;
            this.imgTelp.Location = new System.Drawing.Point(20, 253);
            this.imgTelp.Margin = new System.Windows.Forms.Padding(2);
            this.imgTelp.Name = "imgTelp";
            this.imgTelp.Size = new System.Drawing.Size(35, 35);
            this.imgTelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTelp.TabIndex = 22;
            this.imgTelp.TabStop = false;
            // 
            // imgAlamat
            // 
            this.imgAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgAlamat.Image = global::D_Clinic.Properties.Resources.white_location;
            this.imgAlamat.Location = new System.Drawing.Point(20, 306);
            this.imgAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.imgAlamat.Name = "imgAlamat";
            this.imgAlamat.Size = new System.Drawing.Size(35, 35);
            this.imgAlamat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAlamat.TabIndex = 22;
            this.imgAlamat.TabStop = false;
            // 
            // imgSearchID
            // 
            this.imgSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.imgSearchID.Image = global::D_Clinic.Properties.Resources.white_id_card;
            this.imgSearchID.Location = new System.Drawing.Point(24, 25);
            this.imgSearchID.Margin = new System.Windows.Forms.Padding(2);
            this.imgSearchID.Name = "imgSearchID";
            this.imgSearchID.Size = new System.Drawing.Size(35, 35);
            this.imgSearchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearchID.TabIndex = 50;
            this.imgSearchID.TabStop = false;
            // 
            // imgSearchNama
            // 
            this.imgSearchNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.imgSearchNama.Image = global::D_Clinic.Properties.Resources.white_name;
            this.imgSearchNama.Location = new System.Drawing.Point(24, 76);
            this.imgSearchNama.Margin = new System.Windows.Forms.Padding(2);
            this.imgSearchNama.Name = "imgSearchNama";
            this.imgSearchNama.Size = new System.Drawing.Size(35, 35);
            this.imgSearchNama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearchNama.TabIndex = 51;
            this.imgSearchNama.TabStop = false;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pasienBindingSource
            // 
            this.pasienBindingSource.DataMember = "Pasien";
            this.pasienBindingSource.DataSource = this.dClinicDataSet;
            // 
            // pasienTableAdapter
            // 
            this.pasienTableAdapter.ClearBeforeFill = true;
            // 
            // idPasienDataGridViewTextBoxColumn
            // 
            this.idPasienDataGridViewTextBoxColumn.DataPropertyName = "Id_Pasien";
            this.idPasienDataGridViewTextBoxColumn.HeaderText = "ID Pasien";
            this.idPasienDataGridViewTextBoxColumn.Name = "idPasienDataGridViewTextBoxColumn";
            this.idPasienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaDataGridViewTextBoxColumn.Width = 180;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keluhanDataGridViewTextBoxColumn
            // 
            this.keluhanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.keluhanDataGridViewTextBoxColumn.DataPropertyName = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.HeaderText = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.Name = "keluhanDataGridViewTextBoxColumn";
            this.keluhanDataGridViewTextBoxColumn.ReadOnly = true;
            this.keluhanDataGridViewTextBoxColumn.Width = 154;
            // 
            // Form_Master_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1126, 790);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Master_Pasien";
            this.Text = "Form_Master_Pasien";
            this.Load += new System.EventHandler(this.Form_Master_Pasien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGolDarah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKeluhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlamat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPasien;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2TextBox txNama;
        private Guna.UI2.WinForms.Guna2TextBox txTelp;
        private System.Windows.Forms.PictureBox imgGender;
        private Guna.UI2.WinForms.Guna2TextBox txAlamat;
        private Guna.UI2.WinForms.Guna2TextBox txKeluhan;
        private System.Windows.Forms.PictureBox imgID;
        private System.Windows.Forms.PictureBox imgNama;
        private System.Windows.Forms.PictureBox imgKeluhan;
        private System.Windows.Forms.PictureBox imgTelp;
        private System.Windows.Forms.PictureBox imgAlamat;
        private Guna.UI2.WinForms.Guna2TextBox txCariID;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2TextBox txCariNama;
        private System.Windows.Forms.PictureBox imgSearchID;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private System.Windows.Forms.PictureBox imgSearchNama;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbGolDarah;
        private System.Windows.Forms.PictureBox imgGolDarah;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhanDataGridViewTextBoxColumn;
    }
}
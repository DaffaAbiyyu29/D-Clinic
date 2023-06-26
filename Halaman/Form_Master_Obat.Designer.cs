namespace D_Clinic.Halaman
{
    partial class Form_Master_Obat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaJualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglKadaluarsaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.imgTanggal = new System.Windows.Forms.PictureBox();
            this.dtpKadaluarsa = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbKemasan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.txNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txStok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txHargaBeli = new Guna.UI2.WinForms.Guna2TextBox();
            this.txHargaJual = new Guna.UI2.WinForms.Guna2TextBox();
            this.txMerk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txEfek = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgID = new System.Windows.Forms.PictureBox();
            this.imgStok = new System.Windows.Forms.PictureBox();
            this.imgHargaBeli = new System.Windows.Forms.PictureBox();
            this.imgNama = new System.Windows.Forms.PictureBox();
            this.imgHargaJual = new System.Windows.Forms.PictureBox();
            this.imgEfek = new System.Windows.Forms.PictureBox();
            this.imgMerk = new System.Windows.Forms.PictureBox();
            this.imgKemasan = new System.Windows.Forms.PictureBox();
            this.txCariID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.txCariNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgSearchID = new System.Windows.Forms.PictureBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.imgSearchNama = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.obatTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.ObatTableAdapter();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHargaBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHargaJual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMerk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKemasan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchNama)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.tblKaryawan);
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
            // tblKaryawan
            // 
            this.tblKaryawan.AllowUserToAddRows = false;
            this.tblKaryawan.AllowUserToDeleteRows = false;
            this.tblKaryawan.AllowUserToResizeColumns = false;
            this.tblKaryawan.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblKaryawan.AutoGenerateColumns = false;
            this.tblKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.tblKaryawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblKaryawan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tblKaryawan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tblKaryawan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblKaryawan.ColumnHeadersHeight = 40;
            this.tblKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObatDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.hargaJualDataGridViewTextBoxColumn,
            this.tglKadaluarsaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.tblKaryawan.DataSource = this.obatBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblKaryawan.DefaultCellStyle = dataGridViewCellStyle10;
            this.tblKaryawan.Enabled = false;
            this.tblKaryawan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.Location = new System.Drawing.Point(29, 209);
            this.tblKaryawan.MultiSelect = false;
            this.tblKaryawan.Name = "tblKaryawan";
            this.tblKaryawan.ReadOnly = true;
            this.tblKaryawan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblKaryawan.RowHeadersVisible = false;
            this.tblKaryawan.RowHeadersWidth = 4;
            this.tblKaryawan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblKaryawan.RowTemplate.Height = 30;
            this.tblKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblKaryawan.Size = new System.Drawing.Size(537, 315);
            this.tblKaryawan.TabIndex = 59;
            this.tblKaryawan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblKaryawan.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tblKaryawan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.tblKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.tblKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblKaryawan.ThemeStyle.HeaderStyle.Height = 40;
            this.tblKaryawan.ThemeStyle.ReadOnly = true;
            this.tblKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.tblKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.Height = 30;
            this.tblKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.tblKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            // 
            // idObatDataGridViewTextBoxColumn
            // 
            this.idObatDataGridViewTextBoxColumn.DataPropertyName = "Id_Obat";
            this.idObatDataGridViewTextBoxColumn.HeaderText = "ID Obat";
            this.idObatDataGridViewTextBoxColumn.Name = "idObatDataGridViewTextBoxColumn";
            this.idObatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaJualDataGridViewTextBoxColumn
            // 
            this.hargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga_Jual";
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.hargaJualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.hargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual";
            this.hargaJualDataGridViewTextBoxColumn.Name = "hargaJualDataGridViewTextBoxColumn";
            this.hargaJualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tglKadaluarsaDataGridViewTextBoxColumn
            // 
            this.tglKadaluarsaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tglKadaluarsaDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Kadaluarsa";
            dataGridViewCellStyle9.Format = "dd MMMM yyyy";
            dataGridViewCellStyle9.NullValue = null;
            this.tglKadaluarsaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.tglKadaluarsaDataGridViewTextBoxColumn.HeaderText = "Tgl Kadaluarsa";
            this.tglKadaluarsaDataGridViewTextBoxColumn.Name = "tglKadaluarsaDataGridViewTextBoxColumn";
            this.tglKadaluarsaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tglKadaluarsaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.dClinicDataSet;
            // 
            // dClinicDataSet
            // 
            this.dClinicDataSet.DataSetName = "DClinicDataSet";
            this.dClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnTambah.Text = "Tambah Obat";
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
            this.btnUbah.Text = "Ubah Obat";
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
            this.guna2GroupBox2.Controls.Add(this.imgTanggal);
            this.guna2GroupBox2.Controls.Add(this.dtpKadaluarsa);
            this.guna2GroupBox2.Controls.Add(this.cbKemasan);
            this.guna2GroupBox2.Controls.Add(this.btnSimpan);
            this.guna2GroupBox2.Controls.Add(this.btnUpdate);
            this.guna2GroupBox2.Controls.Add(this.txID);
            this.guna2GroupBox2.Controls.Add(this.btnHapus);
            this.guna2GroupBox2.Controls.Add(this.txNama);
            this.guna2GroupBox2.Controls.Add(this.txStok);
            this.guna2GroupBox2.Controls.Add(this.txHargaBeli);
            this.guna2GroupBox2.Controls.Add(this.txHargaJual);
            this.guna2GroupBox2.Controls.Add(this.txMerk);
            this.guna2GroupBox2.Controls.Add(this.txEfek);
            this.guna2GroupBox2.Controls.Add(this.imgID);
            this.guna2GroupBox2.Controls.Add(this.imgStok);
            this.guna2GroupBox2.Controls.Add(this.imgHargaBeli);
            this.guna2GroupBox2.Controls.Add(this.imgNama);
            this.guna2GroupBox2.Controls.Add(this.imgHargaJual);
            this.guna2GroupBox2.Controls.Add(this.imgEfek);
            this.guna2GroupBox2.Controls.Add(this.imgMerk);
            this.guna2GroupBox2.Controls.Add(this.imgKemasan);
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
            this.guna2GroupBox2.Text = "Detail Obat";
            // 
            // imgTanggal
            // 
            this.imgTanggal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgTanggal.Image = global::D_Clinic.Properties.Resources.white_cal;
            this.imgTanggal.Location = new System.Drawing.Point(20, 370);
            this.imgTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.imgTanggal.Name = "imgTanggal";
            this.imgTanggal.Size = new System.Drawing.Size(35, 35);
            this.imgTanggal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTanggal.TabIndex = 30;
            this.imgTanggal.TabStop = false;
            // 
            // dtpKadaluarsa
            // 
            this.dtpKadaluarsa.Animated = true;
            this.dtpKadaluarsa.BackColor = System.Drawing.Color.Transparent;
            this.dtpKadaluarsa.BorderColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.BorderRadius = 10;
            this.dtpKadaluarsa.BorderThickness = 2;
            this.dtpKadaluarsa.Checked = true;
            this.dtpKadaluarsa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.dtpKadaluarsa.CustomizableEdges.BottomLeft = false;
            this.dtpKadaluarsa.CustomizableEdges.TopRight = false;
            this.dtpKadaluarsa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.Font = new System.Drawing.Font("Porsche Next TT", 12F, System.Drawing.FontStyle.Bold);
            this.dtpKadaluarsa.ForeColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKadaluarsa.HoverState.BorderColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.dtpKadaluarsa.HoverState.ForeColor = System.Drawing.Color.White;
            this.dtpKadaluarsa.Location = new System.Drawing.Point(60, 369);
            this.dtpKadaluarsa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKadaluarsa.MinDate = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpKadaluarsa.Name = "dtpKadaluarsa";
            this.dtpKadaluarsa.Size = new System.Drawing.Size(269, 36);
            this.dtpKadaluarsa.TabIndex = 29;
            this.dtpKadaluarsa.UseTransparentBackground = true;
            this.dtpKadaluarsa.Value = new System.DateTime(2023, 6, 24, 0, 0, 0, 0);
            this.dtpKadaluarsa.Click += new System.EventHandler(this.dtpKadaluarsa_Click);
            // 
            // cbKemasan
            // 
            this.cbKemasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.BorderColor = System.Drawing.Color.White;
            this.cbKemasan.BorderThickness = 2;
            this.cbKemasan.DisabledState.BorderColor = System.Drawing.Color.White;
            this.cbKemasan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.DisabledState.ForeColor = System.Drawing.Color.White;
            this.cbKemasan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKemasan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKemasan.Enabled = false;
            this.cbKemasan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.cbKemasan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.cbKemasan.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.cbKemasan.ForeColor = System.Drawing.Color.White;
            this.cbKemasan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKemasan.ItemHeight = 30;
            this.cbKemasan.Items.AddRange(new object[] {
            "Kemasan",
            "Strip",
            "Botol",
            "Sachet"});
            this.cbKemasan.Location = new System.Drawing.Point(60, 183);
            this.cbKemasan.Margin = new System.Windows.Forms.Padding(2);
            this.cbKemasan.Name = "cbKemasan";
            this.cbKemasan.Size = new System.Drawing.Size(269, 36);
            this.cbKemasan.StartIndex = 0;
            this.cbKemasan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbKemasan.TabIndex = 28;
            this.cbKemasan.Click += new System.EventHandler(this.cbKemasan_Click);
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
            this.txID.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txID.Location = new System.Drawing.Point(60, 39);
            this.txID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txID.MaxLength = 7;
            this.txID.Name = "txID";
            this.txID.PasswordChar = '\0';
            this.txID.PlaceholderForeColor = System.Drawing.Color.White;
            this.txID.PlaceholderText = "ID Obat";
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
            this.txNama.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNama.Location = new System.Drawing.Point(60, 88);
            this.txNama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txNama.MaxLength = 30;
            this.txNama.Name = "txNama";
            this.txNama.PasswordChar = '\0';
            this.txNama.PlaceholderForeColor = System.Drawing.Color.White;
            this.txNama.PlaceholderText = "Nama Obat";
            this.txNama.SelectedText = "";
            this.txNama.Size = new System.Drawing.Size(269, 35);
            this.txNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txNama.TabIndex = 20;
            this.txNama.Click += new System.EventHandler(this.txNama_Click);
            // 
            // txStok
            // 
            this.txStok.Animated = true;
            this.txStok.AutoRoundedCorners = true;
            this.txStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.BorderColor = System.Drawing.Color.White;
            this.txStok.BorderRadius = 16;
            this.txStok.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txStok.BorderThickness = 2;
            this.txStok.Cursor = System.Windows.Forms.Cursors.Default;
            this.txStok.DefaultText = "";
            this.txStok.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txStok.Enabled = false;
            this.txStok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txStok.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txStok.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txStok.Location = new System.Drawing.Point(60, 413);
            this.txStok.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txStok.MaxLength = 3;
            this.txStok.Name = "txStok";
            this.txStok.PasswordChar = '\0';
            this.txStok.PlaceholderForeColor = System.Drawing.Color.White;
            this.txStok.PlaceholderText = "Stok";
            this.txStok.SelectedText = "";
            this.txStok.Size = new System.Drawing.Size(269, 35);
            this.txStok.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txStok.TabIndex = 20;
            this.txStok.Click += new System.EventHandler(this.txStok_Click);
            this.txStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txHargaBeli
            // 
            this.txHargaBeli.Animated = true;
            this.txHargaBeli.AutoRoundedCorners = true;
            this.txHargaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.BorderColor = System.Drawing.Color.White;
            this.txHargaBeli.BorderRadius = 16;
            this.txHargaBeli.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txHargaBeli.BorderThickness = 2;
            this.txHargaBeli.Cursor = System.Windows.Forms.Cursors.Default;
            this.txHargaBeli.DefaultText = "";
            this.txHargaBeli.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txHargaBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txHargaBeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaBeli.Enabled = false;
            this.txHargaBeli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaBeli.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaBeli.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txHargaBeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaBeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txHargaBeli.Location = new System.Drawing.Point(60, 281);
            this.txHargaBeli.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txHargaBeli.MaxLength = 10;
            this.txHargaBeli.Name = "txHargaBeli";
            this.txHargaBeli.PasswordChar = '\0';
            this.txHargaBeli.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaBeli.PlaceholderText = "Harga Beli";
            this.txHargaBeli.SelectedText = "";
            this.txHargaBeli.Size = new System.Drawing.Size(269, 35);
            this.txHargaBeli.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txHargaBeli.TabIndex = 20;
            this.txHargaBeli.TextChanged += new System.EventHandler(this.txHargaBeli_TextChanged);
            this.txHargaBeli.Click += new System.EventHandler(this.txHarga_Click);
            this.txHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // txHargaJual
            // 
            this.txHargaJual.Animated = true;
            this.txHargaJual.AutoRoundedCorners = true;
            this.txHargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.BorderColor = System.Drawing.Color.White;
            this.txHargaJual.BorderRadius = 16;
            this.txHargaJual.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txHargaJual.BorderThickness = 2;
            this.txHargaJual.Cursor = System.Windows.Forms.Cursors.Default;
            this.txHargaJual.DefaultText = "";
            this.txHargaJual.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txHargaJual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txHargaJual.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaJual.Enabled = false;
            this.txHargaJual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaJual.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txHargaJual.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txHargaJual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txHargaJual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txHargaJual.Location = new System.Drawing.Point(60, 326);
            this.txHargaJual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txHargaJual.MaxLength = 10;
            this.txHargaJual.Name = "txHargaJual";
            this.txHargaJual.PasswordChar = '\0';
            this.txHargaJual.PlaceholderForeColor = System.Drawing.Color.White;
            this.txHargaJual.PlaceholderText = "Harga Jual";
            this.txHargaJual.SelectedText = "";
            this.txHargaJual.Size = new System.Drawing.Size(269, 35);
            this.txHargaJual.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txHargaJual.TabIndex = 20;
            // 
            // txMerk
            // 
            this.txMerk.Animated = true;
            this.txMerk.AutoRoundedCorners = true;
            this.txMerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.BorderColor = System.Drawing.Color.White;
            this.txMerk.BorderRadius = 16;
            this.txMerk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txMerk.BorderThickness = 2;
            this.txMerk.Cursor = System.Windows.Forms.Cursors.Default;
            this.txMerk.DefaultText = "";
            this.txMerk.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txMerk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txMerk.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txMerk.Enabled = false;
            this.txMerk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txMerk.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txMerk.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txMerk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txMerk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMerk.Location = new System.Drawing.Point(60, 137);
            this.txMerk.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txMerk.MaxLength = 20;
            this.txMerk.Name = "txMerk";
            this.txMerk.PasswordChar = '\0';
            this.txMerk.PlaceholderForeColor = System.Drawing.Color.White;
            this.txMerk.PlaceholderText = "Merk Obat";
            this.txMerk.SelectedText = "";
            this.txMerk.Size = new System.Drawing.Size(269, 35);
            this.txMerk.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txMerk.TabIndex = 20;
            this.txMerk.Click += new System.EventHandler(this.txMerk_Click);
            // 
            // txEfek
            // 
            this.txEfek.Animated = true;
            this.txEfek.AutoRoundedCorners = true;
            this.txEfek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.BorderColor = System.Drawing.Color.White;
            this.txEfek.BorderRadius = 17;
            this.txEfek.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txEfek.BorderThickness = 2;
            this.txEfek.Cursor = System.Windows.Forms.Cursors.Default;
            this.txEfek.DefaultText = "";
            this.txEfek.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txEfek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txEfek.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEfek.Enabled = false;
            this.txEfek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEfek.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.txEfek.Font = new System.Drawing.Font("Porsche Next TT", 14F, System.Drawing.FontStyle.Bold);
            this.txEfek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.txEfek.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txEfek.Location = new System.Drawing.Point(60, 235);
            this.txEfek.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txEfek.MaxLength = 1000;
            this.txEfek.Name = "txEfek";
            this.txEfek.PasswordChar = '\0';
            this.txEfek.PlaceholderForeColor = System.Drawing.Color.White;
            this.txEfek.PlaceholderText = "Efek Samping";
            this.txEfek.SelectedText = "";
            this.txEfek.Size = new System.Drawing.Size(269, 36);
            this.txEfek.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txEfek.TabIndex = 20;
            this.txEfek.Click += new System.EventHandler(this.txEfek_Click);
            // 
            // imgID
            // 
            this.imgID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgID.Image = global::D_Clinic.Properties.Resources.white_id_card;
            this.imgID.Location = new System.Drawing.Point(20, 48);
            this.imgID.Margin = new System.Windows.Forms.Padding(2);
            this.imgID.Name = "imgID";
            this.imgID.Size = new System.Drawing.Size(35, 35);
            this.imgID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgID.TabIndex = 23;
            this.imgID.TabStop = false;
            // 
            // imgStok
            // 
            this.imgStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgStok.Image = global::D_Clinic.Properties.Resources.white_stok;
            this.imgStok.Location = new System.Drawing.Point(20, 413);
            this.imgStok.Margin = new System.Windows.Forms.Padding(2);
            this.imgStok.Name = "imgStok";
            this.imgStok.Size = new System.Drawing.Size(35, 35);
            this.imgStok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgStok.TabIndex = 22;
            this.imgStok.TabStop = false;
            // 
            // imgHargaBeli
            // 
            this.imgHargaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgHargaBeli.Image = global::D_Clinic.Properties.Resources.white_harga;
            this.imgHargaBeli.Location = new System.Drawing.Point(20, 281);
            this.imgHargaBeli.Margin = new System.Windows.Forms.Padding(2);
            this.imgHargaBeli.Name = "imgHargaBeli";
            this.imgHargaBeli.Size = new System.Drawing.Size(35, 35);
            this.imgHargaBeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHargaBeli.TabIndex = 22;
            this.imgHargaBeli.TabStop = false;
            // 
            // imgNama
            // 
            this.imgNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgNama.Image = global::D_Clinic.Properties.Resources.white_name;
            this.imgNama.Location = new System.Drawing.Point(20, 88);
            this.imgNama.Margin = new System.Windows.Forms.Padding(2);
            this.imgNama.Name = "imgNama";
            this.imgNama.Size = new System.Drawing.Size(35, 35);
            this.imgNama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNama.TabIndex = 22;
            this.imgNama.TabStop = false;
            // 
            // imgHargaJual
            // 
            this.imgHargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgHargaJual.Image = global::D_Clinic.Properties.Resources.white_harga;
            this.imgHargaJual.Location = new System.Drawing.Point(20, 326);
            this.imgHargaJual.Margin = new System.Windows.Forms.Padding(2);
            this.imgHargaJual.Name = "imgHargaJual";
            this.imgHargaJual.Size = new System.Drawing.Size(35, 35);
            this.imgHargaJual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHargaJual.TabIndex = 22;
            this.imgHargaJual.TabStop = false;
            // 
            // imgEfek
            // 
            this.imgEfek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgEfek.Image = global::D_Clinic.Properties.Resources.white_efek;
            this.imgEfek.Location = new System.Drawing.Point(20, 235);
            this.imgEfek.Margin = new System.Windows.Forms.Padding(2);
            this.imgEfek.Name = "imgEfek";
            this.imgEfek.Size = new System.Drawing.Size(35, 35);
            this.imgEfek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEfek.TabIndex = 22;
            this.imgEfek.TabStop = false;
            // 
            // imgMerk
            // 
            this.imgMerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgMerk.Image = global::D_Clinic.Properties.Resources.white_merk;
            this.imgMerk.Location = new System.Drawing.Point(20, 137);
            this.imgMerk.Margin = new System.Windows.Forms.Padding(2);
            this.imgMerk.Name = "imgMerk";
            this.imgMerk.Size = new System.Drawing.Size(35, 35);
            this.imgMerk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMerk.TabIndex = 22;
            this.imgMerk.TabStop = false;
            // 
            // imgKemasan
            // 
            this.imgKemasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(27)))));
            this.imgKemasan.Image = global::D_Clinic.Properties.Resources.white_kemasan;
            this.imgKemasan.Location = new System.Drawing.Point(20, 186);
            this.imgKemasan.Margin = new System.Windows.Forms.Padding(2);
            this.imgKemasan.Name = "imgKemasan";
            this.imgKemasan.Size = new System.Drawing.Size(35, 35);
            this.imgKemasan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgKemasan.TabIndex = 22;
            this.imgKemasan.TabStop = false;
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
            this.txCariID.PlaceholderText = "Kode Obat";
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
            this.txCariNama.PlaceholderText = "Nama Obat";
            this.txCariNama.SelectedText = "";
            this.txCariNama.Size = new System.Drawing.Size(306, 35);
            this.txCariNama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txCariNama.TabIndex = 48;
            this.txCariNama.Click += new System.EventHandler(this.txCariNama_Click);
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
            this.btnCari.Text = "Cari Obat";
            this.btnCari.UseTransparentBackground = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(486, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 95);
            this.label1.TabIndex = 35;
            this.label1.Text = "Obat";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Master_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1126, 790);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Master_Obat";
            this.Text = "Form_Master_Obat";
            this.Load += new System.EventHandler(this.Form_Master_Obat_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHargaBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHargaJual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMerk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKemasan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearchNama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblKaryawan;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbKemasan;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txID;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2TextBox txNama;
        private Guna.UI2.WinForms.Guna2TextBox txMerk;
        private Guna.UI2.WinForms.Guna2TextBox txEfek;
        private System.Windows.Forms.PictureBox imgID;
        private System.Windows.Forms.PictureBox imgNama;
        private System.Windows.Forms.PictureBox imgEfek;
        private System.Windows.Forms.PictureBox imgMerk;
        private System.Windows.Forms.PictureBox imgKemasan;
        private Guna.UI2.WinForms.Guna2TextBox txCariID;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2TextBox txCariNama;
        private System.Windows.Forms.PictureBox imgSearchID;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private System.Windows.Forms.PictureBox imgSearchNama;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKadaluarsa;
        private Guna.UI2.WinForms.Guna2TextBox txHargaJual;
        private System.Windows.Forms.PictureBox imgHargaJual;
        private System.Windows.Forms.PictureBox imgTanggal;
        private Guna.UI2.WinForms.Guna2TextBox txStok;
        private System.Windows.Forms.PictureBox imgStok;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private DClinicDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluarsaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox txHargaBeli;
        private System.Windows.Forms.PictureBox imgHargaBeli;
    }
}
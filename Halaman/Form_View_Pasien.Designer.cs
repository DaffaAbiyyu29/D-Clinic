namespace D_Clinic.Halaman
{
    partial class Form_View_Pasien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dClinicDataSet = new D_Clinic.DClinicDataSet();
            this.pasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasienTableAdapter = new D_Clinic.DClinicDataSetTableAdapters.PasienTableAdapter();
            this.idPasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golonganDarahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).BeginInit();
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
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(68, 134);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(990, 607);
            this.guna2GroupBox1.TabIndex = 40;
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
            this.golonganDarahDataGridViewTextBoxColumn,
            this.telpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
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
            this.tblPasien.Location = new System.Drawing.Point(45, 63);
            this.tblPasien.MultiSelect = false;
            this.tblPasien.Name = "tblPasien";
            this.tblPasien.ReadOnly = true;
            this.tblPasien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPasien.RowHeadersVisible = false;
            this.tblPasien.RowHeadersWidth = 4;
            this.tblPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblPasien.RowTemplate.Height = 30;
            this.tblPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPasien.Size = new System.Drawing.Size(901, 350);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Porsche Next TT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(461, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 95);
            this.label1.TabIndex = 39;
            this.label1.Text = "Pasien";
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
            // golonganDarahDataGridViewTextBoxColumn
            // 
            this.golonganDarahDataGridViewTextBoxColumn.DataPropertyName = "Golongan_Darah";
            this.golonganDarahDataGridViewTextBoxColumn.HeaderText = "Gol Darah";
            this.golonganDarahDataGridViewTextBoxColumn.Name = "golonganDarahDataGridViewTextBoxColumn";
            this.golonganDarahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpDataGridViewTextBoxColumn
            // 
            this.telpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telpDataGridViewTextBoxColumn.DataPropertyName = "Telp";
            this.telpDataGridViewTextBoxColumn.HeaderText = "Telp";
            this.telpDataGridViewTextBoxColumn.Name = "telpDataGridViewTextBoxColumn";
            this.telpDataGridViewTextBoxColumn.ReadOnly = true;
            this.telpDataGridViewTextBoxColumn.Width = 140;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // keluhanDataGridViewTextBoxColumn
            // 
            this.keluhanDataGridViewTextBoxColumn.DataPropertyName = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.HeaderText = "Keluhan";
            this.keluhanDataGridViewTextBoxColumn.Name = "keluhanDataGridViewTextBoxColumn";
            this.keluhanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_View_Pasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1126, 790);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_View_Pasien";
            this.Text = "Form_View_Pasien";
            this.Load += new System.EventHandler(this.Form_View_Pasien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPasien;
        private System.Windows.Forms.Label label1;
        private DClinicDataSet dClinicDataSet;
        private System.Windows.Forms.BindingSource pasienBindingSource;
        private DClinicDataSetTableAdapters.PasienTableAdapter pasienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golonganDarahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhanDataGridViewTextBoxColumn;
    }
}
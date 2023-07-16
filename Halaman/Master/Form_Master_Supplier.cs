using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Clinic.Halaman
{
    public partial class Form_Master_Supplier : Form
    {
        public Form_Master_Supplier()
        {
            InitializeComponent();
        }

        private void Form_Master_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void tblSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.tblSupplier.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void tblSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

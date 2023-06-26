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
    public partial class Form_View_Dokter : Form
    {
        public Form_View_Dokter()
        {
            InitializeComponent();
        }

        private void Form_View_Dokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_Dokter' table. You can move, or remove it, as needed.
            this.view_DokterTableAdapter.Fill(this.dClinicDataSet.View_Dokter);

        }
    }
}

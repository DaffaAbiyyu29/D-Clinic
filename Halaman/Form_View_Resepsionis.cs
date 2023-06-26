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
    public partial class Form_View_Resepsionis : Form
    {
        public Form_View_Resepsionis()
        {
            InitializeComponent();
        }

        private void Form_View_Resepsionis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_Resepsionis' table. You can move, or remove it, as needed.
            this.view_ResepsionisTableAdapter.Fill(this.dClinicDataSet.View_Resepsionis);

        }
    }
}

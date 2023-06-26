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
    public partial class Form_View_Manager : Form
    {
        public Form_View_Manager()
        {
            InitializeComponent();
        }

        private void Form_View_Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dClinicDataSet.View_Manager' table. You can move, or remove it, as needed.
            this.view_ManagerTableAdapter.Fill(this.dClinicDataSet.View_Manager);

        }
    }
}

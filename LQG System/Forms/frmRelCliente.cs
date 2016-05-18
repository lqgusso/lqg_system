using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LQG_System.Forms
{
    public partial class frmRelCliente : Form
    {
        public frmRelCliente()
        {
            InitializeComponent();
        }

        private void frmRelCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }

        private void frmRelCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

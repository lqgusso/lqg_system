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
    public partial class frmRelOS : Form
    {
        public frmRelOS()
        {
            InitializeComponent();
        }

        private void frmRelOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbOrdemServico' table. You can move, or remove it, as needed.
            this.tbOrdemServicoTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbOrdemServico);

            this.reportViewer1.RefreshReport();
        }

        private void frmRelOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

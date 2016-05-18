using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LQG_System.Forms;

namespace LQG_System.Forms
{
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.LQG_SYSTEMConnectionString);

        SqlCommand cmd = null;

        private void tbOrdemServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((nome_clienteComboBox.Text != "") && (nome_servicoTextBox.Text != ""))
                {
                    if (datadiaTextBox.Text == "")
                    {
                        datadiaTextBox.Text = DateTime.Now.ToString();
                    }

                    if (cadastradoporTextBox.Text == "")
                    {
                        cadastradoporTextBox.Text = frmLogin.usuarioConectado;
                    }
                    this.Validate();
                    this.tbOrdemServicoBindingSource.EndEdit();
                    this.tbOrdemServicoTableAdapter.Update(this.lQG_SYSTEMDataSet.tbOrdemServico);
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbCliente);
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbOrdemServico' table. You can move, or remove it, as needed.
            this.tbOrdemServicoTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbOrdemServico);
       }

        private void frmOS_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltrar.Text == "Código OS")
                {
                    string sql = "SELECT * FROM tbOrdemServico WHERE idordem = " + txtPesquisar.Text + "";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable os = new DataTable();

                    da.Fill(os);

                    tbOrdemServicoDataGridView.DataSource = os;
                }

                if (cmbFiltrar.Text == "Cliente")
                {
                    string sql = "SELECT * FROM tbCliente WHERE nome_cliente = " + txtPesquisar.Text + "";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable os = new DataTable();

                    da.Fill(os);

                    tbOrdemServicoDataGridView.DataSource = os;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void LimparCampo()
        {
            idordemTextBox.Clear();
            nome_clienteComboBox.SelectedIndex = -1;
            nome_servicoTextBox.Clear();
            observacaoTextBox.Clear();
            datadiaTextBox.Clear();
            cadastradoporTextBox.Clear();
            valorTextBox.Clear();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Quer realmente fazer logoff?";

            if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                this.tbOrdemServicoTableAdapter.Update(this.lQG_SYSTEMDataSet.tbOrdemServico);
                MessageBox.Show("Ordem de Serviço excluída com sucesso");
            }
        }

        private void tbOrdemServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idordemTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_clienteComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            nome_servicoTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            observacaoTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            datadiaTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[4].Value.ToString();
            cadastradoporTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[5].Value.ToString();
            valorTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}

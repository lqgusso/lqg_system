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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.LQG_SYSTEMConnectionString);
        SqlCommand cmd = null;

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lQG_SYSTEMDataSet);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((idClienteTextBox.Text != "") && (nome_clienteTextBox.Text != ""))
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
                    this.tbClienteBindingSource.EndEdit();
                    this.tbClienteTableAdapter.Update(this.lQG_SYSTEMDataSet.tbCliente);
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Os campos Código e Cliente são obrigatórios");
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
            idClienteTextBox.Clear();
            nome_clienteTextBox.Clear();
            contatoTextBox.Clear();
            dddTextBox.Clear();
            telefoneTextBox.Clear();
            celularTextBox.Clear();
            emailTextBox.Clear();
            enderecoTextBox.Clear();
            bairroTextBox.Clear();
            cepTextBox.Clear();
            cidadeTextBox.Clear();
            estadoComboBox.SelectedIndex = -1;
            cnpjTextBox.Clear();
            inscr_EstTextBox.Clear();
            datadiaTextBox.Clear();
            cadastradoporTextBox.Clear();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbOrdemServico' table. You can move, or remove it, as needed.
            this.tbOrdemServicoTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbOrdemServico);
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbCliente);

        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tbClienteTableAdapter.Update(this.lQG_SYSTEMDataSet.tbCliente);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Quer realmente fazer logoff?";

            if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                this.tbClienteTableAdapter.Update(this.lQG_SYSTEMDataSet.tbCliente);
                MessageBox.Show("Cliente excluído com sucesso");
            }
        }

        private void tbOrdemServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltrar.Text == "Código do Cliente")
                {
                    string sql = "SELECT * FROM tbCliente WHERE idCliente =" + txtPesquisar.Text + "";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable cliente = new DataTable();

                    da.Fill(cliente);

                    tbClienteDataGridView.DataSource = cliente;
                }

                if (cmbFiltrar.Text == "Nome do Cliente")
                {
                    string sql = "SELECT * FROM tbCliente WHERE nome_cliente LIKE '%" + txtPesquisar.Text + "%'";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable cliente = new DataTable();

                    da.Fill(cliente);

                    tbClienteDataGridView.DataSource = cliente;
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

        private void tbClienteDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM tbOrdemServico WHERE nome_cliente = '" + nome_clienteTextBox.Text + "'";

                cmd = new SqlCommand(sql, cn);

                cn.Open();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable os = new DataTable();

                da.Fill(os);

                tbOrdemServicoDataGridView.DataSource = os;
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

        private void tbOrdemServicoDataGridView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idClienteTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_clienteTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            contatoTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            dddTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            celularTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            emailTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[6].Value.ToString();
            enderecoTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            bairroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            cepTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[9].Value.ToString();
            cidadeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[10].Value.ToString();
            estadoComboBox.Text = tbClienteDataGridView.CurrentRow.Cells[11].Value.ToString();
            datadiaTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[12].Value.ToString();
            cadastradoporTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[13].Value.ToString();
        }

        
    }
}

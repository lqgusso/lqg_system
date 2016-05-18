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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.LQG_SYSTEMConnectionString);
        SqlCommand cmd = null;

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((idUsuarioTextBox.Text != "") && (usuarioTextBox.Text != "") && (senhaTextBox.Text != "") 
                    && (repitasenhaTextBox.Text != "") && (nivelacessoComboBox.Text != ""))
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
                    this.tbUsuarioBindingSource.EndEdit();
                    this.tbUsuarioTableAdapter.Update(this.lQG_SYSTEMDataSet.tbUsuario);
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

        private void LimparCampo()
        {
            idUsuarioTextBox.Clear();
            usuarioTextBox.Clear();
            senhaTextBox.Clear();
            repitasenhaTextBox.Clear();
            nivelacessoComboBox.SelectedIndex = -1;
            datadiaTextBox.Clear();
            cadastradoporTextBox.Clear();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbUsuario);
            idUsuarioTextBox.Clear();
            usuarioTextBox.Clear();
            senhaTextBox.Clear();
            repitasenhaTextBox.Clear();
            nivelacessoComboBox.SelectedIndex = -1;
            datadiaTextBox.Clear();
            cadastradoporTextBox.Clear();

        }

        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
             string mensagem = "Quer realmente fazer logoff?";

             if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                 DialogResult.Yes)
             {
                 this.tbUsuarioTableAdapter.Update(this.lQG_SYSTEMDataSet.tbUsuario);
                 MessageBox.Show("Usuário excluído com sucesso");
             }
        }

        private void tbUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idUsuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            usuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            senhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            repitasenhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            nivelacessoComboBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            datadiaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoporTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltrar.Text == "Código do Usuário")
                {
                    string sql = "SELECT *  FROM tbUsuario WHERE idUsuario = " + txtPesquisar + "";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable usuario = new DataTable();

                    da.Fill(usuario);

                    tbUsuarioDataGridView.DataSource = usuario;
                }

                if (cmbFiltrar.Text == "Usuário")
                {
                    string sql = "SELECT *  FROM tbUsuario WHERE usuario = " + txtPesquisar + "";

                    cmd = new SqlCommand(sql, cn);

                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable usuario = new DataTable();

                    da.Fill(usuario);

                    tbUsuarioDataGridView.DataSource = usuario;
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
    }
}


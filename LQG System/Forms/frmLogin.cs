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

namespace LQG_System.Forms
{
    public partial class frmLogin : Form
    {
        public static string nivelAcesso;

        public static string usuarioConectado;
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.LQG_SYSTEMConnectionString);
        
        

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lQG_SYSTEMDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lQG_SYSTEMDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.lQG_SYSTEMDataSet.tbUsuario);

            usuarioComboBox.SelectedIndex = -1;
            nivelacessoComboBox.SelectedIndex = -1;
            senhaTextBox.Clear();

        }

        private void usuarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((usuarioComboBox.Text != "") && (nivelacessoComboBox.Text != "") && 
                    (senhaTextBox.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("Select * from tbUsuario Where usuario = @usuario and " + 
                    "senha = @senha and nivelacesso = @nivel", cn);

                    comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioComboBox.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                    comm.Parameters.Add("@nivel", SqlDbType.VarChar).Value = nivelacessoComboBox.Text;

                    cn.Open();

                    SqlDataReader reader = null;

                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        usuarioConectado = usuarioComboBox.Text;

                        nivelAcesso = nivelacessoComboBox.Text;

                        frmPrincipal p = new frmPrincipal();
                        
                        this.Hide();

                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos", "Aviso de Segurança", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios", "Aviso de Segurança", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

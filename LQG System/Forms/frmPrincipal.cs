using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LQG_System.Forms;

namespace LQG_System.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsslUsuario.Text = "Usuario Conectado: " + frmLogin.usuarioConectado;

            string MyHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + MyHost;

            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(MyHost);
            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tsslIP.Text = "IP: " + myIP;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Now.ToString();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario usuario = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmUsuario)
                    {
                        usuario = (frmUsuario)frm;
                        break;
                    }
                }
                if (usuario == null)
                {
                    usuario = new frmUsuario();
                    usuario.MdiParent = this;
                    usuario.Show();
                }
                usuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ordensDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOS os = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;
                    }
                }
                if  (os == null)
                {
                    os = new frmOS();
                    os.MdiParent = this;
                    os.Show();
                }
                os.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbOS_Click(object sender, EventArgs e)
        {
            try
            {
                frmOS os = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;
                    }
                }
                if (os == null)
                {
                    os = new frmOS();
                    os.MdiParent = this;
                    os.Show();
                }
                os.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelCliente relCliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelCliente)
                    {
                        relCliente = (frmRelCliente)frm;
                        break;
                    }
                }
                
                if (relCliente == null)
                {
                    relCliente = new frmRelCliente();
                    relCliente.MdiParent = this;
                    relCliente.Show();
                }
                relCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ordensDeServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelOS relOS = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelOS)
                    {
                        relOS = (frmRelOS)frm;
                        break;
                    }
                }
                if (relOS == null)
                {
                    relOS = new frmRelOS();
                    relOS.MdiParent = this;
                    relOS.Show();
                }
                relOS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar devido ao erro: " + ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            string mensagem = "Quer realmente fazer logoff?";

            if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == 
                DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}

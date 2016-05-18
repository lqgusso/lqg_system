namespace LQG_System.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label nivelacessoLabel;
            System.Windows.Forms.Label senhaLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nivelacessoComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager();
            this.tbUsuarioTableAdapter = new LQG_System.LQG_SYSTEMDataSetTableAdapters.tbUsuarioTableAdapter();
            this.lQG_SYSTEMDataSet = new LQG_System.LQG_SYSTEMDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            usuarioLabel = new System.Windows.Forms.Label();
            nivelacessoLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(33, 40);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "Usuário:";
            // 
            // nivelacessoLabel
            // 
            nivelacessoLabel.AutoSize = true;
            nivelacessoLabel.Location = new System.Drawing.Point(33, 67);
            nivelacessoLabel.Name = "nivelacessoLabel";
            nivelacessoLabel.Size = new System.Drawing.Size(89, 13);
            nivelacessoLabel.TabIndex = 2;
            nivelacessoLabel.Text = "Nível de Acesso:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(33, 93);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::LQG_System.Properties.Resources.LOGIN_BANNER;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnLogar);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(this.senhaTextBox);
            this.groupBox1.Controls.Add(nivelacessoLabel);
            this.groupBox1.Controls.Add(this.nivelacessoComboBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioComboBox);
            this.groupBox1.Location = new System.Drawing.Point(109, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira o login:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(192, 112);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(111, 112);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 6;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(128, 86);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(126, 20);
            this.senhaTextBox.TabIndex = 5;
            this.senhaTextBox.TextChanged += new System.EventHandler(this.senhaTextBox_TextChanged);
            // 
            // nivelacessoComboBox
            // 
            this.nivelacessoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nivelacessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelacessoComboBox.FormattingEnabled = true;
            this.nivelacessoComboBox.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Operador"});
            this.nivelacessoComboBox.Location = new System.Drawing.Point(128, 59);
            this.nivelacessoComboBox.Name = "nivelacessoComboBox";
            this.nivelacessoComboBox.Size = new System.Drawing.Size(126, 21);
            this.nivelacessoComboBox.TabIndex = 3;
            // 
            // usuarioComboBox
            // 
            this.usuarioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usuarioComboBox.DataSource = this.tbUsuarioBindingSource1;
            this.usuarioComboBox.DisplayMember = "usuario";
            this.usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usuarioComboBox.FormattingEnabled = true;
            this.usuarioComboBox.Location = new System.Drawing.Point(128, 32);
            this.usuarioComboBox.Name = "usuarioComboBox";
            this.usuarioComboBox.Size = new System.Drawing.Size(126, 21);
            this.usuarioComboBox.TabIndex = 1;
            this.usuarioComboBox.ValueMember = "usuario";
            this.usuarioComboBox.SelectedIndexChanged += new System.EventHandler(this.usuarioComboBox_SelectedIndexChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lQG_SYSTEMDataSet
            // 
            this.lQG_SYSTEMDataSet.DataSetName = "LQG_SYSTEMDataSet";
            this.lQG_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // tbUsuarioBindingSource1
            // 
            this.tbUsuarioBindingSource1.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource1.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE LOGIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox usuarioComboBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox nivelacessoComboBox;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private LQG_SYSTEMDataSet lQG_SYSTEMDataSet;
        private LQG_SYSTEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LQG_SYSTEMDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource1;
    }
}
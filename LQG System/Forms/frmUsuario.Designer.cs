namespace LQG_System.Forms
{
    partial class frmUsuario
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
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label repitasenhaLabel;
            System.Windows.Forms.Label datadiaLabel;
            System.Windows.Forms.Label cadastradoporLabel;
            System.Windows.Forms.Label nivelacessoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nivelacessoComboBox = new System.Windows.Forms.ComboBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lQG_SYSTEMDataSet = new LQG_System.LQG_SYSTEMDataSet();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.repitasenhaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuarioTableAdapter = new LQG_System.LQG_SYSTEMDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager();
            this.tbUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datadiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoporTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idUsuarioLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            repitasenhaLabel = new System.Windows.Forms.Label();
            datadiaLabel = new System.Windows.Forms.Label();
            cadastradoporLabel = new System.Windows.Forms.Label();
            nivelacessoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).BeginInit();
            this.Pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).BeginInit();
            this.tbUsuarioBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(42, 27);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(71, 13);
            idUsuarioLabel.TabIndex = 0;
            idUsuarioLabel.Text = "Cód. Usuário:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(42, 53);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(42, 79);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha:";
            // 
            // repitasenhaLabel
            // 
            repitasenhaLabel.AutoSize = true;
            repitasenhaLabel.Location = new System.Drawing.Point(42, 105);
            repitasenhaLabel.Name = "repitasenhaLabel";
            repitasenhaLabel.Size = new System.Drawing.Size(84, 13);
            repitasenhaLabel.TabIndex = 6;
            repitasenhaLabel.Text = "Repita a Senha:";
            // 
            // datadiaLabel
            // 
            datadiaLabel.AutoSize = true;
            datadiaLabel.Location = new System.Drawing.Point(16, 26);
            datadiaLabel.Name = "datadiaLabel";
            datadiaLabel.Size = new System.Drawing.Size(93, 13);
            datadiaLabel.TabIndex = 10;
            datadiaLabel.Text = "Data do Cadastro:";
            // 
            // cadastradoporLabel
            // 
            cadastradoporLabel.AutoSize = true;
            cadastradoporLabel.Location = new System.Drawing.Point(275, 26);
            cadastradoporLabel.Name = "cadastradoporLabel";
            cadastradoporLabel.Size = new System.Drawing.Size(83, 13);
            cadastradoporLabel.TabIndex = 12;
            cadastradoporLabel.Text = "Cadastrado Por:";
            // 
            // nivelacessoLabel
            // 
            nivelacessoLabel.AutoSize = true;
            nivelacessoLabel.Location = new System.Drawing.Point(42, 132);
            nivelacessoLabel.Name = "nivelacessoLabel";
            nivelacessoLabel.Size = new System.Drawing.Size(89, 13);
            nivelacessoLabel.TabIndex = 8;
            nivelacessoLabel.Text = "Nível de Acesso:";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(nivelacessoLabel);
            this.tabPage1.Controls.Add(this.nivelacessoComboBox);
            this.tabPage1.Controls.Add(idUsuarioLabel);
            this.tabPage1.Controls.Add(this.idUsuarioTextBox);
            this.tabPage1.Controls.Add(usuarioLabel);
            this.tabPage1.Controls.Add(this.usuarioTextBox);
            this.tabPage1.Controls.Add(senhaLabel);
            this.tabPage1.Controls.Add(this.senhaTextBox);
            this.tabPage1.Controls.Add(repitasenhaLabel);
            this.tabPage1.Controls.Add(this.repitasenhaTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nivelacessoComboBox
            // 
            this.nivelacessoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nivelacesso", true));
            this.nivelacessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelacessoComboBox.FormattingEnabled = true;
            this.nivelacessoComboBox.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuário"});
            this.nivelacessoComboBox.Location = new System.Drawing.Point(137, 124);
            this.nivelacessoComboBox.Name = "nivelacessoComboBox";
            this.nivelacessoComboBox.Size = new System.Drawing.Size(154, 21);
            this.nivelacessoComboBox.TabIndex = 9;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // lQG_SYSTEMDataSet
            // 
            this.lQG_SYSTEMDataSet.DataSetName = "LQG_SYSTEMDataSet";
            this.lQG_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "idUsuario", true));
            this.idUsuarioTextBox.Enabled = false;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(135, 20);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUsuarioTextBox.TabIndex = 1;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(137, 46);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(228, 20);
            this.usuarioTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(137, 72);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(154, 20);
            this.senhaTextBox.TabIndex = 5;
            // 
            // repitasenhaTextBox
            // 
            this.repitasenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "repitasenha", true));
            this.repitasenhaTextBox.Location = new System.Drawing.Point(137, 98);
            this.repitasenhaTextBox.Name = "repitasenhaTextBox";
            this.repitasenhaTextBox.PasswordChar = '*';
            this.repitasenhaTextBox.Size = new System.Drawing.Size(154, 20);
            this.repitasenhaTextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Pesquisar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUsuarioDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(7, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuários";
            // 
            // tbUsuarioDataGridView
            // 
            this.tbUsuarioDataGridView.AllowUserToAddRows = false;
            this.tbUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.tbUsuarioDataGridView.AutoGenerateColumns = false;
            this.tbUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbUsuarioDataGridView.DataSource = this.tbUsuarioBindingSource1;
            this.tbUsuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuarioDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbUsuarioDataGridView.Name = "tbUsuarioDataGridView";
            this.tbUsuarioDataGridView.ReadOnly = true;
            this.tbUsuarioDataGridView.Size = new System.Drawing.Size(604, 124);
            this.tbUsuarioDataGridView.TabIndex = 0;
            this.tbUsuarioDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbUsuarioDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod. Usuário";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "senha";
            this.dataGridViewTextBoxColumn3.HeaderText = "senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "repitasenha";
            this.dataGridViewTextBoxColumn4.HeaderText = "repitasenha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nivelacesso";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nível de Acesso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "datadia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data do Cadastro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cadastradopor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Controls.Add(this.btnPesquisar);
            this.Pesquisar.Controls.Add(this.txtPesquisar);
            this.Pesquisar.Controls.Add(this.label2);
            this.Pesquisar.Controls.Add(this.cmbFiltrar);
            this.Pesquisar.Controls.Add(this.label1);
            this.Pesquisar.Location = new System.Drawing.Point(7, 7);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(610, 62);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.TabStop = false;
            this.Pesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(482, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(289, 20);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(186, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "",
            "Código do Usuário",
            "Usuário"});
            this.cmbFiltrar.Location = new System.Drawing.Point(68, 20);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(194, 21);
            this.cmbFiltrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar Por:";
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbUsuarioBindingNavigator
            // 
            this.tbUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbUsuarioBindingNavigator.BindingSource = this.tbUsuarioBindingSource;
            this.tbUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbUsuarioBindingNavigator.CountItemFormat = "De {0}";
            this.tbUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbUsuarioBindingNavigatorSaveItem});
            this.tbUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbUsuarioBindingNavigator.Name = "tbUsuarioBindingNavigator";
            this.tbUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbUsuarioBindingNavigator.Size = new System.Drawing.Size(714, 25);
            this.tbUsuarioBindingNavigator.TabIndex = 1;
            this.tbUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo registro";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "De {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de registros";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir registro";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover para o primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover para o anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover para o próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover para o último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUsuarioBindingNavigatorSaveItem
            // 
            this.tbUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbUsuarioBindingNavigatorSaveItem.Image")));
            this.tbUsuarioBindingNavigatorSaveItem.Name = "tbUsuarioBindingNavigatorSaveItem";
            this.tbUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbUsuarioBindingNavigatorSaveItem.Text = "Salvar registro";
            this.tbUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbUsuarioBindingNavigatorSaveItem_Click);
            // 
            // datadiaTextBox
            // 
            this.datadiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "datadia", true));
            this.datadiaTextBox.Location = new System.Drawing.Point(115, 19);
            this.datadiaTextBox.Name = "datadiaTextBox";
            this.datadiaTextBox.Size = new System.Drawing.Size(144, 20);
            this.datadiaTextBox.TabIndex = 11;
            // 
            // cadastradoporTextBox
            // 
            this.cadastradoporTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cadastradopor", true));
            this.cadastradoporTextBox.Location = new System.Drawing.Point(364, 19);
            this.cadastradoporTextBox.Name = "cadastradoporTextBox";
            this.cadastradoporTextBox.Size = new System.Drawing.Size(140, 20);
            this.cadastradoporTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(datadiaLabel);
            this.groupBox1.Controls.Add(this.datadiaTextBox);
            this.groupBox1.Controls.Add(cadastradoporLabel);
            this.groupBox1.Controls.Add(this.cadastradoporTextBox);
            this.groupBox1.Location = new System.Drawing.Point(46, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 55);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobre o cadastro";
            // 
            // tbUsuarioBindingSource1
            // 
            this.tbUsuarioBindingSource1.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource1.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbUsuarioBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).EndInit();
            this.Pesquisar.ResumeLayout(false);
            this.Pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).EndInit();
            this.tbUsuarioBindingNavigator.ResumeLayout(false);
            this.tbUsuarioBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LQG_SYSTEMDataSet lQG_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private LQG_SYSTEMDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private LQG_SYSTEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox repitasenhaTextBox;
        private System.Windows.Forms.TextBox datadiaTextBox;
        private System.Windows.Forms.TextBox cadastradoporTextBox;
        private System.Windows.Forms.ComboBox nivelacessoComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox Pesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource1;
    }
}
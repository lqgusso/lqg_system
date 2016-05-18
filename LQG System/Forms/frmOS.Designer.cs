namespace LQG_System.Forms
{
    partial class frmOS
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
            System.Windows.Forms.Label idordemLabel;
            System.Windows.Forms.Label data_osLabel;
            System.Windows.Forms.Label nome_servicoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label datadiaLabel;
            System.Windows.Forms.Label cadastradoporLabel;
            System.Windows.Forms.Label nome_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            System.Windows.Forms.Label valorLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nome_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lQG_SYSTEMDataSet = new LQG_System.LQG_SYSTEMDataSet();
            this.tbClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idordemTextBox = new System.Windows.Forms.TextBox();
            this.data_osDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nome_servicoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbOrdemServicoTableAdapter = new LQG_System.LQG_SYSTEMDataSetTableAdapters.tbOrdemServicoTableAdapter();
            this.tableAdapterManager = new LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager();
            this.tbOrdemServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbOrdemServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datadiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoporTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbClienteTableAdapter = new LQG_System.LQG_SYSTEMDataSetTableAdapters.tbClienteTableAdapter();
            this.fKtbOrdemServicotbClientenomeclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOrdemServicoDataGridView = new System.Windows.Forms.DataGridView();
            idordemLabel = new System.Windows.Forms.Label();
            data_osLabel = new System.Windows.Forms.Label();
            nome_servicoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            datadiaLabel = new System.Windows.Forms.Label();
            cadastradoporLabel = new System.Windows.Forms.Label();
            nome_clienteLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).BeginInit();
            this.tbOrdemServicoBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbOrdemServicotbClientenomeclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idordemLabel
            // 
            idordemLabel.AutoSize = true;
            idordemLabel.Location = new System.Drawing.Point(24, 14);
            idordemLabel.Name = "idordemLabel";
            idordemLabel.Size = new System.Drawing.Size(68, 13);
            idordemLabel.TabIndex = 0;
            idordemLabel.Text = "Cod.  da OS:";
            // 
            // data_osLabel
            // 
            data_osLabel.AutoSize = true;
            data_osLabel.Location = new System.Drawing.Point(24, 39);
            data_osLabel.Name = "data_osLabel";
            data_osLabel.Size = new System.Drawing.Size(66, 13);
            data_osLabel.TabIndex = 2;
            data_osLabel.Text = "Data da OS:";
            // 
            // nome_servicoLabel
            // 
            nome_servicoLabel.AutoSize = true;
            nome_servicoLabel.Location = new System.Drawing.Point(24, 92);
            nome_servicoLabel.Name = "nome_servicoLabel";
            nome_servicoLabel.Size = new System.Drawing.Size(106, 13);
            nome_servicoLabel.TabIndex = 6;
            nome_servicoLabel.Text = "Serviços Realizados:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(22, 140);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 8;
            observacaoLabel.Text = "Observação:";
            // 
            // datadiaLabel
            // 
            datadiaLabel.AutoSize = true;
            datadiaLabel.Location = new System.Drawing.Point(22, 26);
            datadiaLabel.Name = "datadiaLabel";
            datadiaLabel.Size = new System.Drawing.Size(45, 13);
            datadiaLabel.TabIndex = 10;
            datadiaLabel.Text = "datadia:";
            // 
            // cadastradoporLabel
            // 
            cadastradoporLabel.AutoSize = true;
            cadastradoporLabel.Location = new System.Drawing.Point(197, 26);
            cadastradoporLabel.Name = "cadastradoporLabel";
            cadastradoporLabel.Size = new System.Drawing.Size(78, 13);
            cadastradoporLabel.TabIndex = 12;
            cadastradoporLabel.Text = "cadastradopor:";
            // 
            // nome_clienteLabel
            // 
            nome_clienteLabel.AutoSize = true;
            nome_clienteLabel.Location = new System.Drawing.Point(24, 66);
            nome_clienteLabel.Name = "nome_clienteLabel";
            nome_clienteLabel.Size = new System.Drawing.Size(88, 13);
            nome_clienteLabel.TabIndex = 9;
            nome_clienteLabel.Text = "Nome do Cliente:";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(valorLabel);
            this.tabPage1.Controls.Add(this.valorTextBox);
            this.tabPage1.Controls.Add(nome_clienteLabel);
            this.tabPage1.Controls.Add(this.nome_clienteComboBox);
            this.tabPage1.Controls.Add(idordemLabel);
            this.tabPage1.Controls.Add(this.idordemTextBox);
            this.tabPage1.Controls.Add(data_osLabel);
            this.tabPage1.Controls.Add(this.data_osDateTimePicker);
            this.tabPage1.Controls.Add(nome_servicoLabel);
            this.tabPage1.Controls.Add(this.nome_servicoTextBox);
            this.tabPage1.Controls.Add(observacaoLabel);
            this.tabPage1.Controls.Add(this.observacaoTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nome_clienteComboBox
            // 
            this.nome_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "nome_cliente", true));
            this.nome_clienteComboBox.DataSource = this.tbClienteBindingSource1;
            this.nome_clienteComboBox.DisplayMember = "nome_cliente";
            this.nome_clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_clienteComboBox.FormattingEnabled = true;
            this.nome_clienteComboBox.Location = new System.Drawing.Point(136, 58);
            this.nome_clienteComboBox.Name = "nome_clienteComboBox";
            this.nome_clienteComboBox.Size = new System.Drawing.Size(281, 21);
            this.nome_clienteComboBox.TabIndex = 10;
            this.nome_clienteComboBox.ValueMember = "nome_cliente";
            // 
            // tbOrdemServicoBindingSource
            // 
            this.tbOrdemServicoBindingSource.DataMember = "tbOrdemServico";
            this.tbOrdemServicoBindingSource.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // lQG_SYSTEMDataSet
            // 
            this.lQG_SYSTEMDataSet.DataSetName = "LQG_SYSTEMDataSet";
            this.lQG_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource1
            // 
            this.tbClienteBindingSource1.DataMember = "tbCliente";
            this.tbClienteBindingSource1.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // idordemTextBox
            // 
            this.idordemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idordem", true));
            this.idordemTextBox.Enabled = false;
            this.idordemTextBox.Location = new System.Drawing.Point(136, 7);
            this.idordemTextBox.Name = "idordemTextBox";
            this.idordemTextBox.Size = new System.Drawing.Size(85, 20);
            this.idordemTextBox.TabIndex = 1;
            // 
            // data_osDateTimePicker
            // 
            this.data_osDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbOrdemServicoBindingSource, "data_os", true));
            this.data_osDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_osDateTimePicker.Location = new System.Drawing.Point(136, 32);
            this.data_osDateTimePicker.Name = "data_osDateTimePicker";
            this.data_osDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.data_osDateTimePicker.TabIndex = 3;
            // 
            // nome_servicoTextBox
            // 
            this.nome_servicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "nome_servico", true));
            this.nome_servicoTextBox.Location = new System.Drawing.Point(136, 85);
            this.nome_servicoTextBox.Multiline = true;
            this.nome_servicoTextBox.Name = "nome_servicoTextBox";
            this.nome_servicoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nome_servicoTextBox.Size = new System.Drawing.Size(281, 49);
            this.nome_servicoTextBox.TabIndex = 7;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(136, 140);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoTextBox.Size = new System.Drawing.Size(281, 63);
            this.observacaoTextBox.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbOrdemServicoDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(17, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OS(s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(382, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(214, 21);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(162, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "",
            "Código OS",
            "Cliente"});
            this.cmbFiltrar.Location = new System.Drawing.Point(67, 20);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar Por:";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.lQG_SYSTEMDataSet;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemServicoTableAdapter = this.tbOrdemServicoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LQG_System.LQG_SYSTEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbOrdemServicoBindingNavigator
            // 
            this.tbOrdemServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbOrdemServicoBindingNavigator.BindingSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbOrdemServicoBindingNavigator.CountItemFormat = "De {0}";
            this.tbOrdemServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbOrdemServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbOrdemServicoBindingNavigatorSaveItem});
            this.tbOrdemServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbOrdemServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbOrdemServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbOrdemServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbOrdemServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbOrdemServicoBindingNavigator.Name = "tbOrdemServicoBindingNavigator";
            this.tbOrdemServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbOrdemServicoBindingNavigator.Size = new System.Drawing.Size(658, 25);
            this.tbOrdemServicoBindingNavigator.TabIndex = 1;
            this.tbOrdemServicoBindingNavigator.Text = "bindingNavigator1";
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
            // tbOrdemServicoBindingNavigatorSaveItem
            // 
            this.tbOrdemServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOrdemServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbOrdemServicoBindingNavigatorSaveItem.Image")));
            this.tbOrdemServicoBindingNavigatorSaveItem.Name = "tbOrdemServicoBindingNavigatorSaveItem";
            this.tbOrdemServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbOrdemServicoBindingNavigatorSaveItem.Text = "Salvar registro";
            this.tbOrdemServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbOrdemServicoBindingNavigatorSaveItem_Click);
            // 
            // datadiaTextBox
            // 
            this.datadiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "datadia", true));
            this.datadiaTextBox.Location = new System.Drawing.Point(73, 19);
            this.datadiaTextBox.Name = "datadiaTextBox";
            this.datadiaTextBox.Size = new System.Drawing.Size(118, 20);
            this.datadiaTextBox.TabIndex = 11;
            // 
            // cadastradoporTextBox
            // 
            this.cadastradoporTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "cadastradopor", true));
            this.cadastradoporTextBox.Location = new System.Drawing.Point(281, 19);
            this.cadastradoporTextBox.Name = "cadastradoporTextBox";
            this.cadastradoporTextBox.Size = new System.Drawing.Size(200, 20);
            this.cadastradoporTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(datadiaLabel);
            this.groupBox1.Controls.Add(this.cadastradoporTextBox);
            this.groupBox1.Controls.Add(cadastradoporLabel);
            this.groupBox1.Controls.Add(this.datadiaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(69, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobre o cadastro";
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // fKtbOrdemServicotbClientenomeclienteBindingSource
            // 
            this.fKtbOrdemServicotbClientenomeclienteBindingSource.DataMember = "FK_tbOrdemServico_tbCliente_nome_cliente";
            this.fKtbOrdemServicotbClientenomeclienteBindingSource.DataSource = this.tbClienteBindingSource;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(24, 216);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 10;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(136, 209);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(85, 20);
            this.valorTextBox.TabIndex = 11;
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cadastradopor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "datadia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data do Cadastro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "observacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome_servico";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_os";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data da OS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idordem";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod. OS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // tbOrdemServicoDataGridView
            // 
            this.tbOrdemServicoDataGridView.AllowUserToAddRows = false;
            this.tbOrdemServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbOrdemServicoDataGridView.AutoGenerateColumns = false;
            this.tbOrdemServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOrdemServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbOrdemServicoDataGridView.DataSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrdemServicoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbOrdemServicoDataGridView.Name = "tbOrdemServicoDataGridView";
            this.tbOrdemServicoDataGridView.ReadOnly = true;
            this.tbOrdemServicoDataGridView.Size = new System.Drawing.Size(584, 129);
            this.tbOrdemServicoDataGridView.TabIndex = 0;
            this.tbOrdemServicoDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbOrdemServicoDataGridView_MouseDoubleClick);
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbOrdemServicoBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Ordens de Serviços";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOS_FormClosed);
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).EndInit();
            this.tbOrdemServicoBindingNavigator.ResumeLayout(false);
            this.tbOrdemServicoBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbOrdemServicotbClientenomeclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LQG_SYSTEMDataSet lQG_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private LQG_SYSTEMDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
        private LQG_SYSTEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbOrdemServicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbOrdemServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox nome_clienteComboBox;
        private System.Windows.Forms.TextBox idordemTextBox;
        private System.Windows.Forms.DateTimePicker data_osDateTimePicker;
        private System.Windows.Forms.TextBox nome_servicoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datadiaTextBox;
        private System.Windows.Forms.TextBox cadastradoporTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private LQG_SYSTEMDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.BindingSource fKtbOrdemServicotbClientenomeclienteBindingSource;
        private System.Windows.Forms.BindingSource tbClienteBindingSource1;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DataGridView tbOrdemServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
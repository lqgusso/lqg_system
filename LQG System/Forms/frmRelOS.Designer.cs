﻿namespace LQG_System.Forms
{
    partial class frmRelOS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lQG_SYSTEMDataSet = new LQG_System.LQG_SYSTEMDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbOrdemServicoTableAdapter = new LQG_System.LQG_SYSTEMDataSetTableAdapters.tbOrdemServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelOSDataSet";
            reportDataSource1.Value = this.tbOrdemServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LQG_System.Forms.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(658, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRelOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Ordens de Serviços";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelOS_FormClosed);
            this.Load += new System.EventHandler(this.frmRelOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lQG_SYSTEMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LQG_SYSTEMDataSet lQG_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private LQG_SYSTEMDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
    }
}
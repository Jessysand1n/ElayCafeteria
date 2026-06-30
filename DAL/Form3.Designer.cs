namespace DAL
{
    partial class Form3
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
            this.eLAYCAFETERIADataSet2 = new DAL.ELAYCAFETERIADataSet2();
            this.sPMOSTRARDETALLEPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMOSTRARDETALLEPEDIDOTableAdapter = new DAL.ELAYCAFETERIADataSet2TableAdapters.SPMOSTRARDETALLEPEDIDOTableAdapter();
            this.eLAYCAFETERIADataSet = new DAL.ELAYCAFETERIADataSet();
            this.sPMOSTRARPEDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMOSTRARPEDIDOSTableAdapter = new DAL.ELAYCAFETERIADataSetTableAdapters.SPMOSTRARPEDIDOSTableAdapter();
            this.sPMOSTRARDETALLEPEDIDOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPMOSTRARDETALLEPEDIDOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPMOSTRARDETALLEPEDIDOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sPMOSTRARDETALLEPEDIDOBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.eLAYCAFETERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMOSTRARPEDIDOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPEDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPEDIDOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eLAYCAFETERIADataSet2
            // 
            this.eLAYCAFETERIADataSet2.DataSetName = "ELAYCAFETERIADataSet2";
            this.eLAYCAFETERIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMOSTRARDETALLEPEDIDOBindingSource
            // 
            this.sPMOSTRARDETALLEPEDIDOBindingSource.DataMember = "SPMOSTRARDETALLEPEDIDO";
            this.sPMOSTRARDETALLEPEDIDOBindingSource.DataSource = this.eLAYCAFETERIADataSet2;
            // 
            // sPMOSTRARDETALLEPEDIDOTableAdapter
            // 
            this.sPMOSTRARDETALLEPEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // eLAYCAFETERIADataSet
            // 
            this.eLAYCAFETERIADataSet.DataSetName = "ELAYCAFETERIADataSet";
            this.eLAYCAFETERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMOSTRARPEDIDOSBindingSource
            // 
            this.sPMOSTRARPEDIDOSBindingSource.DataMember = "SPMOSTRARPEDIDOS";
            this.sPMOSTRARPEDIDOSBindingSource.DataSource = this.eLAYCAFETERIADataSet;
            // 
            // sPMOSTRARPEDIDOSTableAdapter
            // 
            this.sPMOSTRARPEDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // sPMOSTRARDETALLEPEDIDOBindingSource1
            // 
            this.sPMOSTRARDETALLEPEDIDOBindingSource1.DataMember = "SPMOSTRARDETALLEPEDIDO";
            this.sPMOSTRARDETALLEPEDIDOBindingSource1.DataSource = this.eLAYCAFETERIADataSet2;
            // 
            // sPMOSTRARDETALLEPEDIDOBindingSource2
            // 
            this.sPMOSTRARDETALLEPEDIDOBindingSource2.DataMember = "SPMOSTRARDETALLEPEDIDO";
            this.sPMOSTRARDETALLEPEDIDOBindingSource2.DataSource = this.eLAYCAFETERIADataSet2;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPMOSTRARPEDIDOSBindingSource1;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "DAL.Report3.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(800, 450);
            this.reportViewer5.TabIndex = 0;
            // 
            // sPMOSTRARDETALLEPEDIDOBindingSource3
            // 
            this.sPMOSTRARDETALLEPEDIDOBindingSource3.DataMember = "SPMOSTRARDETALLEPEDIDO";
            this.sPMOSTRARDETALLEPEDIDOBindingSource3.DataSource = this.eLAYCAFETERIADataSet2;
            // 
            // sPMOSTRARDETALLEPEDIDOBindingSource4
            // 
            this.sPMOSTRARDETALLEPEDIDOBindingSource4.DataMember = "SPMOSTRARDETALLEPEDIDO";
            this.sPMOSTRARDETALLEPEDIDOBindingSource4.DataSource = this.eLAYCAFETERIADataSet2;
            // 
            // eLAYCAFETERIADataSetBindingSource
            // 
            this.eLAYCAFETERIADataSetBindingSource.DataSource = this.eLAYCAFETERIADataSet;
            this.eLAYCAFETERIADataSetBindingSource.Position = 0;
            // 
            // sPMOSTRARPEDIDOSBindingSource1
            // 
            this.sPMOSTRARPEDIDOSBindingSource1.DataMember = "SPMOSTRARPEDIDOS";
            this.sPMOSTRARPEDIDOSBindingSource1.DataSource = this.eLAYCAFETERIADataSetBindingSource;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPEDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARDETALLEPEDIDOBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPEDIDOSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sPMOSTRARDETALLEPEDIDOBindingSource;
        private ELAYCAFETERIADataSet2 eLAYCAFETERIADataSet2;
        private ELAYCAFETERIADataSet2TableAdapters.SPMOSTRARDETALLEPEDIDOTableAdapter sPMOSTRARDETALLEPEDIDOTableAdapter;
        private ELAYCAFETERIADataSet eLAYCAFETERIADataSet;
        private System.Windows.Forms.BindingSource sPMOSTRARPEDIDOSBindingSource;
        private ELAYCAFETERIADataSetTableAdapters.SPMOSTRARPEDIDOSTableAdapter sPMOSTRARPEDIDOSTableAdapter;
        private System.Windows.Forms.BindingSource sPMOSTRARDETALLEPEDIDOBindingSource1;
        private System.Windows.Forms.BindingSource sPMOSTRARDETALLEPEDIDOBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource sPMOSTRARDETALLEPEDIDOBindingSource3;
        private System.Windows.Forms.BindingSource sPMOSTRARDETALLEPEDIDOBindingSource4;
        private System.Windows.Forms.BindingSource sPMOSTRARPEDIDOSBindingSource1;
        private System.Windows.Forms.BindingSource eLAYCAFETERIADataSetBindingSource;
    }
}
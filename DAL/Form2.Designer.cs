namespace DAL
{
    partial class Form2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eLAYCAFETERIADataSet1 = new DAL.ELAYCAFETERIADataSet1();
            this.categoriaproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_productoTableAdapter = new DAL.ELAYCAFETERIADataSet1TableAdapters.Categoria_productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaproductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.categoriaproductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DAL.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // eLAYCAFETERIADataSet1
            // 
            this.eLAYCAFETERIADataSet1.DataSetName = "ELAYCAFETERIADataSet1";
            this.eLAYCAFETERIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaproductoBindingSource
            // 
            this.categoriaproductoBindingSource.DataMember = "Categoria_producto";
            this.categoriaproductoBindingSource.DataSource = this.eLAYCAFETERIADataSet1;
            // 
            // categoria_productoTableAdapter
            // 
            this.categoria_productoTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLAYCAFETERIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaproductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ELAYCAFETERIADataSet1 eLAYCAFETERIADataSet1;
        private System.Windows.Forms.BindingSource categoriaproductoBindingSource;
        private ELAYCAFETERIADataSet1TableAdapters.Categoria_productoTableAdapter categoria_productoTableAdapter;
    }
}
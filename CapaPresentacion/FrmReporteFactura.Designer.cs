namespace CapaPresentacion
{
    partial class FrmReporteFactura
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
            this.reporte_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsPrincipal = new CapaPresentacion.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_facturaTableAdapter = new CapaPresentacion.DsPrincipalTableAdapters.reporte_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_facturaBindingSource
            // 
            this.reporte_facturaBindingSource.DataMember = "reporte_factura";
            this.reporte_facturaBindingSource.DataSource = this.DsPrincipal;
            // 
            // DsPrincipal
            // 
            this.DsPrincipal.DataSetName = "DsPrincipal";
            this.DsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptcomprobanteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte_facturaTableAdapter
            // 
            this.reporte_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteFactura";
            this.Text = "FrmReporteFactura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_facturaBindingSource;
        private DsPrincipal DsPrincipal;
        private DsPrincipalTableAdapters.reporte_facturaTableAdapter reporte_facturaTableAdapter;
    }
}
namespace Stock
{
    partial class Supplier_Report
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
            this.StockDataSet5 = new StockDataSet5();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierTableAdapter = new StockDataSet5TableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SupplierBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.Supplier_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(90, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockDataSet5
            // 
            this.StockDataSet5.DataSetName = "StockDataSet5";
            this.StockDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataMember = "Supplier";
            this.SupplierBindingSource.DataSource = this.StockDataSet5;
            // 
            // SupplierTableAdapter
            // 
            this.SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // Supplier_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 457);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier_Report";
            this.Text = "Supplier_Report";
            this.Load += new System.EventHandler(this.Supplier_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private StockDataSet5 StockDataSet5;
        private StockDataSet5TableAdapters.SupplierTableAdapter SupplierTableAdapter;
    }
}
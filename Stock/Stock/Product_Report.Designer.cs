namespace Stock
{
    partial class Product_Report
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
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockDataSet2 = new StockDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductsTableAdapter = new StockDataSet2TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataMember = "Products";
            this.ProductsBindingSource.DataSource = this.StockDataSet2;
            // 
            // StockDataSet2
            // 
            this.StockDataSet2.DataSetName = "StockDataSet2";
            this.StockDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.Product_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(86, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductsTableAdapter
            // 
            this.ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // Product_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_Report";
            this.Text = "Product_Report";
            this.Load += new System.EventHandler(this.Product_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private StockDataSet2 StockDataSet2;
        private StockDataSet2TableAdapters.ProductsTableAdapter ProductsTableAdapter;
    }
}
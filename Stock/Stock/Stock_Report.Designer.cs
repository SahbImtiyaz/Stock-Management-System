namespace Stock
{
    partial class Stock_Report
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
            this.StockDataSet4 = new StockDataSet4();
            this.StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockTableAdapter = new StockDataSet4TableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.Stock_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(74, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockDataSet4
            // 
            this.StockDataSet4.DataSetName = "StockDataSet4";
            this.StockDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StockBindingSource
            // 
            this.StockBindingSource.DataMember = "Stock";
            this.StockBindingSource.DataSource = this.StockDataSet4;
            // 
            // StockTableAdapter
            // 
            this.StockTableAdapter.ClearBeforeFill = true;
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 418);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock_Report";
            this.Text = "Stock_Report";
            this.Load += new System.EventHandler(this.Stock_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StockBindingSource;
        private StockDataSet4 StockDataSet4;
        private StockDataSet4TableAdapters.StockTableAdapter StockTableAdapter;
    }
}
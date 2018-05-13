namespace Stock
{
    partial class Warehouse_Report
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
            this.StockDataSet6 = new StockDataSet6();
            this.WarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WarehouseTableAdapter = new StockDataSet6TableAdapters.WarehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.WarehouseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.Warehouse_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(76, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockDataSet6
            // 
            this.StockDataSet6.DataSetName = "StockDataSet6";
            this.StockDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WarehouseBindingSource
            // 
            this.WarehouseBindingSource.DataMember = "Warehouse";
            this.WarehouseBindingSource.DataSource = this.StockDataSet6;
            // 
            // WarehouseTableAdapter
            // 
            this.WarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // Warehouse_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 428);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warehouse_Report";
            this.Text = "Warehouse_Report";
            this.Load += new System.EventHandler(this.Warehouse_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WarehouseBindingSource;
        private StockDataSet6 StockDataSet6;
        private StockDataSet6TableAdapters.WarehouseTableAdapter WarehouseTableAdapter;
    }
}
namespace Stock
{
    partial class User_Report
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
            this.StockDataSet7 = new StockDataSet7();
            this.LoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginTableAdapter = new StockDataSet7TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LoginBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.User_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(83, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockDataSet7
            // 
            this.StockDataSet7.DataSetName = "StockDataSet7";
            this.StockDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginBindingSource
            // 
            this.LoginBindingSource.DataMember = "Login";
            this.LoginBindingSource.DataSource = this.StockDataSet7;
            // 
            // LoginTableAdapter
            // 
            this.LoginTableAdapter.ClearBeforeFill = true;
            // 
            // User_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 435);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "User_Report";
            this.Text = "User_Report";
            this.Load += new System.EventHandler(this.User_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoginBindingSource;
        private StockDataSet7 StockDataSet7;
        private StockDataSet7TableAdapters.LoginTableAdapter LoginTableAdapter;
    }
}
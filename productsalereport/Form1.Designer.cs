namespace productsalereport
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtProductNameFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPdf = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.tablePanel1.SetColumn(this.btnGenerateReport, 5);
            this.btnGenerateReport.Location = new System.Drawing.Point(660, 468);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.tablePanel1.SetRow(this.btnGenerateReport, 2);
            this.btnGenerateReport.Size = new System.Drawing.Size(202, 29);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Preview";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // StartDatePicker
            // 
            this.tablePanel1.SetColumn(this.StartDatePicker, 1);
            this.StartDatePicker.CustomFormat = "dd-MM-yyyy";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(95, 22);
            this.StartDatePicker.Name = "StartDatePicker";
            this.tablePanel1.SetRow(this.StartDatePicker, 0);
            this.StartDatePicker.Size = new System.Drawing.Size(202, 21);
            this.StartDatePicker.TabIndex = 7;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged_1);
            // 
            // EndDatePicker
            // 
            this.tablePanel1.SetColumn(this.EndDatePicker, 5);
            this.EndDatePicker.CustomFormat = "dd-MM-yyyy";
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(660, 22);
            this.EndDatePicker.Name = "EndDatePicker";
            this.tablePanel1.SetRow(this.EndDatePicker, 0);
            this.EndDatePicker.Size = new System.Drawing.Size(202, 21);
            this.EndDatePicker.TabIndex = 8;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged_1);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Start Date";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.labelControl2, 4);
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(590, 26);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "End Date";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.txtProductNameFilter);
            this.tablePanel1.Controls.Add(this.btnFilter);
            this.tablePanel1.Controls.Add(this.btnPrintPdf);
            this.tablePanel1.Controls.Add(this.StartDatePicker);
            this.tablePanel1.Controls.Add(this.btnGenerateReport);
            this.tablePanel1.Controls.Add(this.EndDatePicker);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 46F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 410F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(875, 510);
            this.tablePanel1.TabIndex = 12;
            this.tablePanel1.UseSkinIndents = true;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // txtProductNameFilter
            // 
            this.tablePanel1.SetColumn(this.txtProductNameFilter, 3);
            this.txtProductNameFilter.Location = new System.Drawing.Point(384, 22);
            this.txtProductNameFilter.Name = "txtProductNameFilter";
            this.tablePanel1.SetRow(this.txtProductNameFilter, 0);
            this.txtProductNameFilter.Size = new System.Drawing.Size(202, 21);
            this.txtProductNameFilter.TabIndex = 14;
            this.txtProductNameFilter.TextChanged += new System.EventHandler(this.txtProductNameFilter_TextChanged);
            // 
            // btnFilter
            // 
            this.tablePanel1.SetColumn(this.btnFilter, 2);
            this.btnFilter.Location = new System.Drawing.Point(301, 471);
            this.btnFilter.Name = "btnFilter";
            this.tablePanel1.SetRow(this.btnFilter, 2);
            this.btnFilter.Size = new System.Drawing.Size(78, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPrintPdf
            // 
            this.tablePanel1.SetColumn(this.btnPrintPdf, 3);
            this.btnPrintPdf.Location = new System.Drawing.Point(384, 471);
            this.btnPrintPdf.Name = "btnPrintPdf";
            this.tablePanel1.SetRow(this.btnPrintPdf, 2);
            this.btnPrintPdf.Size = new System.Drawing.Size(202, 23);
            this.btnPrintPdf.TabIndex = 12;
            this.btnPrintPdf.Text = "Export PDF";
            this.btnPrintPdf.Click += new System.EventHandler(this.BtnExportPdf_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(301, 26);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Product Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 510);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Form1";
            this.Text = "Product Sale Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPdf;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.TextBox txtProductNameFilter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
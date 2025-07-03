namespace productsalereport.src.Reports
{
    partial class report
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.db_productDataSet1 = new productsalereport.db_productDataSet();
            this.pRODUCTSALESTableAdapter = new productsalereport.db_productDataSetTableAdapters.PRODUCTSALESTableAdapter();
            this.db_productDataSet2 = new productsalereport.db_productDataSet();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Name = "Detail";
            // 
            // db_productDataSet1
            // 
            this.db_productDataSet1.DataSetName = "db_productDataSet";
            this.db_productDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSALESTableAdapter
            // 
            this.pRODUCTSALESTableAdapter.ClearBeforeFill = true;
            // 
            // db_productDataSet2
            // 
            this.db_productDataSet2.DataSetName = "db_productDataSet";
            this.db_productDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PRODUCTCODE]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 24.58334F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(305.2083F, 36.54167F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UNITPRICE]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(375F, 38.12501F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.db_productDataSet1,
            this.db_productDataSet2});
            this.DataAdapter = this.pRODUCTSALESTableAdapter;
            this.DataMember = "PRODUCTSALES";
            this.DataSource = this.db_productDataSet2;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_productDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private db_productDataSet db_productDataSet1;
        private db_productDataSetTableAdapters.PRODUCTSALESTableAdapter pRODUCTSALESTableAdapter;
        private db_productDataSet db_productDataSet2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}

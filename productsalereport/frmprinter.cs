using DevExpress.XtraEditors;
using productsalereport.src.dto.dt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productsalereport
{
    public partial class frmprinter : DevExpress.XtraEditors.XtraForm
    {
        public frmprinter()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            


        }
        public void ShowReport(DevExpress.XtraReports.UI.XtraReport report)
        {
            if (report != null)
            {
                ProductSaleReport.DocumentSource = report;
                report.CreateDocument();
            }
            else
            {
                XtraMessageBox.Show("No report to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }

}
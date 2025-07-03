using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace productsalereport.src.Reports
{
    public partial class ProductReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductReport()
        {
            InitializeComponent();
           

        }
       
        public void SetReportDates(DateTime startDate, DateTime endDate)
        {
            lblStartDate.Text = "Start Date: " + startDate.ToString("dd-MM-yyyy");
            lblEndDate.Text = "End Date: " + endDate.ToString("dd-MM-yyyy");
        }

    }
}

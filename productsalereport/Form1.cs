using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using productsalereport.src.Config;
using productsalereport.src.dto.dt;
using productsalereport.src.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace productsalereport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string fontDirectory = Path.Combine(Application.StartupPath, "Fonts");

                if (!Directory.Exists(fontDirectory))
                {
                    Directory.CreateDirectory(fontDirectory);
                }

                // 3. Define the full path to the font file
                string fontPath = Path.Combine(fontDirectory, "Kantumruy-Bold.ttf");

                if (File.Exists(fontPath))
                {
                    // 4. Load the font into the DevExpress repository
                    DXFontRepository.Instance.AddFont(fontPath);
                }
                else
                {
                    MessageBox.Show($"Font file not found in the output directory:\n{fontPath}", "Font Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load custom font: " + ex.Message, "Font Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;
            string productNameFilter = txtProductNameFilter?.Text.Trim() ?? "";

            string message = $"No sales records were found for the selected date range: {startDate:d} to {endDate:d}.";
            string title = "No Records Found";

            try
            {
                var repo = new SaleRepository();
                List<SaleDto> sales = repo.GetSales(startDate, endDate, productNameFilter);
                var groupedSales = sales
                .GroupBy(s => new { s.ProductCode, s.ProductName, s.UnitPrice })
                .Select(g => new SaleDto
                {
                    ProductCode = g.Key.ProductCode,
                    ProductName = g.Key.ProductName,
                    UnitPrice = g.Key.UnitPrice,
                    Quantity = g.Sum(x => x.Quantity),
                    
                })
                .ToList();

                if (sales.Count == 0)
                {
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var report = new ProductReport();
                report.DataSource = groupedSales;
                report.SetReportDates(startDate, endDate);
                //ProductReport report = new ProductReport { DataSource = sales };
                //report.SetReportDates(startDate, endDate);

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex);
                MessageBox.Show("An error occurred while generating the report. Please check the logs in /src/logs/errors.txt.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterSales()
        {
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;
            string productNameFilter = txtProductNameFilter?.Text.Trim();
            productNameFilter = string.IsNullOrWhiteSpace(productNameFilter) ? null : productNameFilter;


            try
            {
                var repo = new SaleRepository();
                var sales = repo.GetSales(startDate, endDate, productNameFilter);

                if (sales.Count == 0)
                    return;

                ProductReport report = new ProductReport { DataSource = sales };
                report.SetReportDates(startDate, endDate);

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex);
                MessageBox.Show("An error occurred while filtering the report. Please check the logs.",
                                "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value.Date;
            DateTime endDate = EndDatePicker.Value.Date;
            string productNameFilter = txtProductNameFilter?.Text.Trim() ?? "";

            try
            {
                var repo = new SaleRepository();
                List<SaleDto> sales = repo.GetSales(startDate, endDate, productNameFilter);

                if (sales.Count == 0)
                {
                    MessageBox.Show("No sales data to export.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Save report as PDF"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProductReport report = new ProductReport { DataSource = sales };
                    report.SetReportDates(startDate, endDate );
                    
                    report.CreateDocument();

                    report.ExportToPdf(saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex);
                MessageBox.Show("An error occurred while exporting the report. Please check the logs.",
                                "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     

        private void EndDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < StartDatePicker.Value)
                StartDatePicker.Value = EndDatePicker.Value;
            StartDatePicker.MaxDate = EndDatePicker.Value;
        }
        private void StartDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < StartDatePicker.Value)
                EndDatePicker.Value = StartDatePicker.Value;

            EndDatePicker.MinDate = StartDatePicker.Value;
        }

        private void txtProductNameFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterSales();
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

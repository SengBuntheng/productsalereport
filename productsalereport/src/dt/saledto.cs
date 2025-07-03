using DevExpress.XtraReports.UI.CrossTab;
using System;
using System.ComponentModel.DataAnnotations;

namespace productsalereport.src.dto.dt
{
    public class SaleDto
    {
        [Key]
        public int SaleId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }


        public decimal UnitPrice { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal Total => UnitPrice * Quantity;  




        public SaleDto() { }


        public SaleDto(int saleId, string productCode, string productName, int quantity, decimal unitPrice, DateTime saleDate)
        {
            SaleId = saleId;
            ProductCode = productCode;
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            SaleDate = saleDate;
        }
    }
}

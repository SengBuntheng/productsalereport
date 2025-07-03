using Dapper;
using productsalereport.src.Config;
using productsalereport.src.Database;
using productsalereport.src.dto.dt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public class SaleRepository
{
    public List<SaleDto> GetSales(DateTime startDate, DateTime endDate, string productName)
    {
        try
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                return connection.Query<SaleDto>(
                    "usp_GetProductSales",
                    new { StartDate = startDate, EndDate = endDate, ProductName = productName },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
        catch (Exception ex)
        {
            ErrorLogger.Log(ex);
            return new List<SaleDto>();
        }
    }
}

using System.Data.SqlClient;
using System.Configuration; // Add a reference to System.Configuration in your project

namespace productsalereport.src.Database
{
   
    public static class DatabaseHelper
    {
       
        private static readonly string ConnectionString = "Data Source=DESKTOP-021PA1H\\MSSQLSERVER01;Initial Catalog=db_product;User ID=sa;Password=123";

     
        public static SqlConnection GetConnection()
        {
            
            return new SqlConnection(ConnectionString);
        }
    }
}

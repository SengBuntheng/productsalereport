Product Sales Report
This is a Windows Forms application built in C# that generates a product sales report for a specified date range. It connects to a SQL Server database, fetches sales data, and displays it in a clean, printable DevExpress XtraReport.
The application demonstrates several key features:
Date range selection with validation.
Secure database querying using parameterized queries.
Integration with DevExpress XtraReports for professional reporting.
Dynamic loading of custom fonts to ensure consistent report styling across different machines.


Here is an example of the generated report output:
Setup Steps
Follow these steps to get the application running on your local machine.
1. Database Setup
This application requires a SQL Server database. For ease of use, we recommend using SQL Server Express LocalDB, which is included with Visual Studio.
a. Create the Database:
In Visual Studio, go to View > SQL Server Object Explorer.
Right-click on (localdb)\MSSQLLocalDB and select New Query.
Run the following script to create the database and table:
-- Create the database
CREATE DATABASE db_product;
GO

-- Switch to the new database
USE db_product;
GO

-- Create the sales table
CREATE TABLE PRODUCTSALES (
    SaleId INT PRIMARY KEY IDENTITY(1,1),
    ProductCode NVARCHAR(50),
    ProductName NVARCHAR(100),
    Quantity INT,
    UnitPrice DECIMAL(18, 2),
    SaleDate DATETIME
);
GO

-- Insert some sample data
INSERT INTO PRODUCTSALES (ProductCode, ProductName, Quantity, UnitPrice, SaleDate) VALUES
('P001', 'Pen', 15, 1.50, '2025-07-01'),
('P002', 'Notebook', 3, 3.20, '2025-07-02'),
('P003', 'Eraser', 15, 0.80, '2025-07-03');
GO


b. Update the Connection String:
Open the src/Database/DatabaseHelper.cs file.
Find the ConnectionString variable.
If you used LocalDB, update it to the following:
private static readonly string ConnectionString = "Data Source=DESKTOP-021PA1H\\MSSQLSERVER01;Initial Catalog=db_product;User ID=sa;Password=yourpassword";


If you are using a different SQL Server instance, update the Data Source, User ID, and Password accordingly.
2. Restore NuGet Packages
Right-click on the solution in the Solution Explorer and select Restore NuGet Packages. This will download the required DevExpress and other libraries.
3. Custom Font Setup
The report uses the "Kantumruy" custom font. The project is configured to load this font automatically using the recommended Deployment-Ready Approach.
Ensure the font file Kantumruy-Bold.ttf is in the Fonts folder in your project.
Verify the file property Copy to Output Directory is set to Copy if newer.
The code in Form1_Load will handle loading the font. No further action is needed.
4. Build and Run
In the Visual Studio menu, go to Build > Rebuild Solution.
Press F5 or click the Start button to run the application.

![image](https://github.com/user-attachments/assets/b83894a2-5298-4383-9f79-090aa9648574)
![image](https://github.com/user-attachments/assets/ee85cb9a-ee96-486a-888f-16d4f85c4e83)


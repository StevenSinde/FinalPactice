using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;


namespace FinalPractice
{
    class DataAccessSale
    {
        public List<Sale> PullData(string id)
        {
            List<Sale> Reader = new List<Sale>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["WW"].ConnectionString))
            {
                Reader = connection.Query<Sale>($"SELECT [Salesperson Key] AS SalespersonKey ,[WWI Invoice ID] AS WWInvoice ,[Description],[Total Excluding Tax] AS Total FROM [Fact].[Sale] WHERE [Total Excluding Tax] < '{id}'ORDER BY Total DESC").ToList();
                return Reader;
            }

            //adding line comment to test commits 
        }
    }
}

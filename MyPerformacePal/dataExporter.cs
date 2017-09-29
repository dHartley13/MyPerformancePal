using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MyPerformacePal
{
    class dataExporter
    {
        private void endGameExporter(int GameID)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPerformancePal;Integrated Security=True";
            using (var dbConnection = new SqlConnection(connectionString))
            {
                try
                {
                    dbConnection.Open();
                    var sqlCommand = new SqlCommand("[dbo].[getDataforExport]", dbConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@gameID", GameID));

                    //do something with excel

                }
                catch
                {
                    //some error
                }
                finally
                {
                    dbConnection.Close();
                }
           }

        }
    }
}

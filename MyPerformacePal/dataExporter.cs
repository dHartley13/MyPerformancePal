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
                dbConnection.Open();
                var sqlCommand = new SqlCommand(, dbConnection);
                
            }
        }
    }
}

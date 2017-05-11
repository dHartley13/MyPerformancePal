using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyPerformacePal
{
    //Interface
    public interface IComboBoxItemGetter
    {
        List<string> RetrieveCategories();
        List<string> RetrieveSetPieces(object coordinatePercentages);
    }

    class ComboBoxItemGetter : IComboBoxItemGetter
    { 

        public List<string> RetrieveCategories()
        {
            List<string> items = new List<string>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPerformancePal;Integrated Security=True";
            using (SqlConnection dbconnection = new SqlConnection(connectionString))
            {
                try
                {
                    string sqlCommand = "Select [ActionText] from dbo.actionDropDownLookup";
                    SqlCommand cmd = new SqlCommand(sqlCommand, dbconnection);
                    dbconnection.Open();

                    using (var cmboDataReader = cmd.ExecuteReader())
                    {
                        while (cmboDataReader.Read())
                        {
                            items.Add(cmboDataReader["ActionText"].ToString());
                        }
                    }
                    return items;
                }
                catch 
                {
                    return items; 
                }
                finally
                {
                    dbconnection.Close();
                }
            }
        
        }

        public List<string> RetrieveSetPieces(object coordinatePercentages)
        {
            List<string> items = new List<string>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPerformancePal;Integrated Security=True";
            using (SqlConnection dbconnection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    dbconnection.Open();
                    var sqlCommand = new SqlCommand("[dbo].[getSetPieceOptionsbyRegion]", dbconnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@coordinatesX", coordinatePercentages.xPercentage));
                    sqlCommand.Parameters.Add(new SqlParameter("@coordinatesY", coordinatePercentages.yPercentage));

                    using (var cmboDataReader = sqlCommand.ExecuteReader())
                    {
                        while (cmboDataReader.Read())
                        {
                            items.Add(cmboDataReader["[setPieceTypeName]"].ToString()); 
                        }
                    }
                    return items;
                }
                catch 
                {
                    return items;
                }
                finally
                {
                    dbconnection.Close();
                }
            }

        }
    }
}

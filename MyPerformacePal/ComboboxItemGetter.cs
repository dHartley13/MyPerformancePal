using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace MyPerformacePal
{
    //Interface
    public interface IComboBoxItemGetter
    {
        List<string> RetrieveCategories();
        List<string> RetrieveSetPieces(decimal coordinatesX, decimal coordinatesY);
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

        public List<string> RetrieveSetPieces(decimal coordinatesX, decimal coordinatesY)
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
                    sqlCommand.Parameters.Add(new SqlParameter("@coordinatesX", coordinatesX));
                    sqlCommand.Parameters.Add(new SqlParameter("@coordinatesY", coordinatesY));

                    sqlCommand.ExecuteNonQuery();

                    //using data adapter as executing a non query so cannot use ExecuteReader
                    var cmboDataReader = new SqlDataAdapter(sqlCommand);
                    var setPieceDataset = new DataSet();
                    cmboDataReader.Fill(setPieceDataset);

                    foreach (DataRow setPieceRow in setPieceDataset.Tables[0].Rows)
                    {
                        items.Add(setPieceRow[0].ToString());
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

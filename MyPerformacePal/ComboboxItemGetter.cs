using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyPerformacePal
{
    class ComboBoxItemGetter
    {
        public List<string> RetrieveCategories()
        {
            List<string> items = new List<string>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            using (SqlConnection dbconnection = new SqlConnection(connectionString))
            {
                try
                {
                    string sqlCommand = "Select [Text] from master.dbo.actionDropDownLookup";
                    SqlCommand cmd = new SqlCommand(sqlCommand, dbconnection);
                    dbconnection.Open();

                    using (var cmboDataReader = cmd.ExecuteReader())
                    {
                        while (cmboDataReader.Read())
                        {
                            items.Add(cmboDataReader["Text"].ToString());
                        }
                    }
                    return items;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return items; //this doesn't seem right
                }
                finally
                {
                    dbconnection.Close();
                }
            }
        
        }
    }
}

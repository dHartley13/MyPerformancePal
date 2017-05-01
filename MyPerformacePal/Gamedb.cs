using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{
    //Interface
    public interface IGameDb
    {
        int CreateGame();
        void SaveAction(int actionTypeValue, string actionChoice, int gameID);
    }

    class Gamedb : IGameDb
    {
        //Public functions
        public int CreateGame()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPerformancePal;Integrated Security=True";
            using (var dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                var sqlCommand = new SqlCommand("dbo.getNextGameID", dbConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                var returnParam = new SqlParameter
                {
                    ParameterName = "@NewGameID",
                    Direction = System.Data.ParameterDirection.ReturnValue
                };
                sqlCommand.Parameters.Add(returnParam);
                try
                {
                    sqlCommand.ExecuteNonQuery();                                   //execute the query
                    Console.WriteLine("dbo.getNextGameID was successfull");         //post that its been successful
                    return (int)returnParam.Value;                                  //return the gameID from the SP                    
                }
                catch (Exception ex)
                {
                    return -1;
                    throw new InvalidOperationException("Couldn't start the game");   
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }


        public void SaveAction(int actionType, string chosenAction, int gameID)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPerformancePal;Integrated Security=True";
            using (var dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                var sqlCommand = new SqlCommand("dbo.insertRawGameData", dbConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@gameID", gameID));
                sqlCommand.Parameters.Add(new SqlParameter("@ActionType", actionType));
                sqlCommand.Parameters.Add(new SqlParameter("@chosenAction", chosenAction));

                try
                {
                    sqlCommand.ExecuteNonQuery();                                   //execute the query
                    Console.WriteLine("dbo.insertRawGameData Insert successfull");                        //post that its been successful               
                }
                catch (Exception ex)
                {
                    Console.WriteLine("dbo.insertRawGameData was not ran successfully" + ": " + ex.Message);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
    }
}

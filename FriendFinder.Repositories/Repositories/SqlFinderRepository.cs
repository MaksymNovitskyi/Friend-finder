using FriendFinder.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FriendFinder.Repositories.Repositories
{
    public class SqlFinderRepository : SqlBaseRepository, IFinderRepository
    {
        public SqlFinderRepository(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Used for searching the best matched friends from the whole database.
        /// Returns the best one, if you set quantity to 1.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IEnumerable<int> GetIdsOfTheMostSuitablePersons(int userID, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    //REVIEW TK: what is the point of 'responseMessage'?
                    var responseMessage = string.Empty;
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetTheMostAppropriate;
                    command.Parameters.AddWithValue("@ParticipantID", userID);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    List<int> resID = new List<int>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            resID.Add((int)reader["Id"]);
                        }
                    }

                    return resID;
                }
            }
        }

        /// <summary>
        /// Searching random user.
        /// </summary>
        /// <param name="currentUserID"></param>
        /// <returns>Returns random user from the whole database, except user with currentUserID.</returns>
        public int GetRandomID(int currentUserID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    //REVIEW TK: what is the point of 'responseMessage'?
                    var responseMessage = string.Empty;
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetRandomId;
                    command.Parameters.AddWithValue("@myID", currentUserID);

                    int resID = -1;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            resID = (int)reader["Id"];
                        }
                    }

                    return resID;
                }
            }
        }
    }
}

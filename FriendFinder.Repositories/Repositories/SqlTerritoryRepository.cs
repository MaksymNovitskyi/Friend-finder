using FriendFinder.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace FriendFinder.Repositories.Repositories
{
    public class SqlTerritoryRepository : SqlBaseRepository,  ITerritoryRepository
    {
        public SqlTerritoryRepository(string connectionString) : base(connectionString)
        {
        }

        public int UpdateTerritory(int userID, string region, string city)
        {
            if (region != null && city != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spUpdateTerritory;
                        command.Parameters.AddWithValue("@ParticipantID", userID);
                        command.Parameters.AddWithValue("@pRegion", region);
                        command.Parameters.AddWithValue("@pCity", city);
                       
                        return command.ExecuteNonQuery();
                    }
                }
            }

            return -1;
        }
    }
}

using FriendFinder.Repositories.Helpers;
using FriendFinder.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FriendFinder.Repositories.Repositories
{
    public class SqlPersonRepository : SqlBaseRepository, IPersonRepository
    {
        public SqlPersonRepository(string connectionString) : base(connectionString)
        {
        }

        public int UpdatePerson(int id, string name, string surname, char gender, string dateOfBirth)
        {
            if (name != null && surname != null && Helper.IsValidGender(gender) && Helper.IsValidDateOfBirth(dateOfBirth))
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spUpdatePerson;
                        command.Parameters.AddWithValue("@pId", id);
                        command.Parameters.AddWithValue("@pName", name);
                        command.Parameters.AddWithValue("@pSurname", surname);
                        command.Parameters.AddWithValue("@pGender", gender);
                        command.Parameters.AddWithValue("@pDateOfBirth", DateTime.Parse(dateOfBirth).Date).DbType = DbType.Date;

                        return command.ExecuteNonQuery();
                    }
                }
            }

            return -1;
        } 
    }
}

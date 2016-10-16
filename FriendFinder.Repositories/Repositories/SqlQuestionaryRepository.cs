using FriendFinder.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace FriendFinder.Repositories.Repositories
{
    public class SqlQuestionaryRepository : SqlBaseRepository, IQuestionaryRepository
    {
        public SqlQuestionaryRepository(string connectionString) : base(connectionString)
        {
        }

        public int UpdateQuestionary(int userID, string education, string musicgenre, 
            string moviegenre, int smoking, int alcohol, string politicalviews)
        {
            if (education != null && musicgenre != null && moviegenre != null &&
                smoking >= -1 && smoking <= 1 && alcohol >=-1 && alcohol <= 1 &&
                    politicalviews != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spUpdateQuestionary;
                        command.Parameters.AddWithValue("@ParticipantID", userID);
                        command.Parameters.AddWithValue("@pEducation", education);
                        command.Parameters.AddWithValue("@pFavoriteMusicGenre", musicgenre);
                        command.Parameters.AddWithValue("@pFavoriteMovieGenre", moviegenre);
                        command.Parameters.AddWithValue("@pViewsOnSmoking", smoking);
                        command.Parameters.AddWithValue("@pViewsOnAlcohol", alcohol);
                        command.Parameters.AddWithValue("@pPoliticalViews", politicalviews);

                        return command.ExecuteNonQuery();
                    }
                }
            }

            return -1;
        }
    }
}

using System;
using FriendFinder.Entities;
using FriendFinder.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;
using FriendFinder.Repositories.Repositories;
using FriendFinder.Repositories.Helpers;

namespace FriendFinder.Repositories
{
    public class SqlUserRepository : SqlBaseRepository, IUserRepository
    {
        public SqlUserRepository(string connectionString) : base(connectionString)
        {
        }

        public User GetUserByEmail(string email, string password)
        {
            var encryptedPassword = (new Encryptor()).Encrypt(password);

            if (email != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        var responseMessage = string.Empty;
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spLogin;
                        command.Parameters.AddWithValue("@pEmailAddress", email);
                        command.Parameters.AddWithValue("@pPassword", encryptedPassword);
                        command.Parameters.AddWithValue("@responseMessage", responseMessage);

                        var user = Helper.ReadUser(command);
                        return user;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Some parameters equal null");
            }
        }

        public User GetParticipant(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetAllInfoAboutParticipant;
                    command.Parameters.AddWithValue("@ParticipantID", id);

                    var user = Helper.ReadUser(command);
                    return user;
                }
            }
        }
        

        public int RemoveParticipant(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spRemoveParticipant;
                    command.Parameters.AddWithValue("@ParticipantID", id);

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int UpdateEmailAddress(int id, string emailaddress)
        {
            if (emailaddress != null && Helper.IsValidEmail(emailaddress))
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spUpdateEmailAddress;
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@pEmailAddress", emailaddress);

                        return command.ExecuteNonQuery();
                    }
                }
            }

            return -1;
        }


        public int UpdatePhotoLink(int id, string photolink)
        {
            if (photolink != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spUpdatePhotoLink;
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@pPhotoLink", photolink);

                        return command.ExecuteNonQuery();
                    }
                }
            }

            return -1;
        }

        //REVIEW TK: this looks like a hell!
        public int AddParticipant(string name, string surname, char gender, string dateOfBirth, 
            string region, string city, string education, string musicgenre, 
            string moviegenre, int smoking, int alcohol, string politicalviews, 
            string photolink, string emailaddress, string password, string response)
        {
            if (education != null && musicgenre != null && moviegenre != null && dateOfBirth != null &&
                region != null && city != null && emailaddress != null && password != null &&
                name != null && surname != null && politicalviews != null &&
                smoking >= -1 && smoking <= 1 && alcohol >= -1 && alcohol <= 1 && response != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spAddParticipant;
                        command.Parameters.AddWithValue("@pName", name);
                        command.Parameters.AddWithValue("@pSurname", surname);
                        command.Parameters.AddWithValue("@pGender", gender);
                        command.Parameters.AddWithValue("@pDateOfBirth", DateTime.Parse(dateOfBirth).Date).DbType = DbType.Date;
                        command.Parameters.AddWithValue("@pRegion", region);
                        command.Parameters.AddWithValue("@pCity", city);
                        command.Parameters.AddWithValue("@pEducation", education);
                        command.Parameters.AddWithValue("@pFavoriteMusicGenre", musicgenre);
                        command.Parameters.AddWithValue("@pFavoriteMovieGenre", moviegenre);
                        command.Parameters.AddWithValue("@pViewsOnSmoking", smoking);
                        command.Parameters.AddWithValue("@pViewsOnAlcohol", alcohol);
                        command.Parameters.AddWithValue("@pPoliticalViews", politicalviews);
                        command.Parameters.AddWithValue("@pPhotoLink", photolink);
                        command.Parameters.AddWithValue("@pEmailAddress", emailaddress);
                        command.Parameters.AddWithValue("@pPassword", password);
                        command.Parameters.AddWithValue("@responseMessage", response);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            return 0;
        }
    }
}

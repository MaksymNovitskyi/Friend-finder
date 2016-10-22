using FriendFinder.Entities;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FriendFinder.Repositories.Helpers
{
    //REVIEW TK: Don't know if i'm right, but i think reader is the only think that belongs here, everything else should be in UI.(unmarked)
    //Consider separating validators into different file.
    public static class Helper
    {
        public static bool IsValidEmail(string emailaddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailaddress);
            return match.Success;
        }

        public static bool IsValidGender(char gender)
        {
            return gender == 'M' || gender == 'W' ? true : false;
        }

        public static bool IsValidDateOfBirth(string dt)
        {
            if (dt == null)
            {
                return false;
            }

            var date = DateTime.Now;
            CultureInfo ci = new CultureInfo("en-GB");
            try
            {
                DateTime.TryParseExact(dt, "yyyy-MM-dd", ci, DateTimeStyles.None, out date);
            }
            catch (Exception)
            {
                return false;
            }

            //REVIEW TK: return date < DateTime.Now;
            return date < DateTime.Now ? true : false;
        }

        public static string IntToViewsOn(int item)
        {
            return item == 0 ? "Neutral" : item == 1 ? "Positive" : "Negative";
        }

        public static int ViewsOnToInt(string views)
        {
            switch (views)
            {
                case "Neutral":
                    return 0;
                case "Positive":
                    return 1;
                case "Negative":
                    return -1;
                default:
                    throw new ArgumentException("Incorrect input");
            }
        }

        public static User ReadUser(SqlCommand command)
        {
            User user = null;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    user = new User()
                    {
                        Id = (int)reader["Id"],
                        EmailAddress = (string)reader["EmailAddress"],
                        PhotoLink = (string)(reader["PhotoLink"] is DBNull ? string.Empty : reader["PhotoLink"]),
                        Person = new Person()
                        {
                            Name = (string)reader["Name"],
                            Surname = (string)reader["Surname"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Gender = ((string)reader["Gender"])[0]
                        },
                        Territory = new Territory()
                        {
                            Region = (string)reader["Region"],
                            City = (string)reader["City"]
                        },
                        Questionary = new Questionary()
                        {
                            Education = (string)reader["Education"],
                            FavoriteMusicGenre = (string)reader["FavoriteMusicGenre"],
                            FavoriteMovieGenre = (string)reader["FavoriteMovieGenre"],
                            PoliticalViews = (string)reader["PoliticalViews"],
                            ViewsOnSmoking = (int)reader["ViewsOnSmoking"],
                            ViewsOnAlcohol = (int)reader["ViewsOnAlcohol"]
                        }
                    };
                }
            }

            return user;
        }
    }
}

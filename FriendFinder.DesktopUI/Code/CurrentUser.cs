using FriendFinder.Entities;
using System;

namespace FriendFinder.Code
{
    class CurrentUser
    {
        private static User _currentUser;

        public static void Initialize(User user)
        {
            if (_currentUser != null)
            {
                throw new InvalidOperationException("This user has already logged in");
            }
            _currentUser = user;
        }

        public static void Logout()
        {
            _currentUser = null;
        }

        public static Person GetPersonInfo()
        {
            return _currentUser.Person;
        }

        public static Questionary GetQuestionaryInfo()
        {
            return _currentUser.Questionary;
        }

        public static Territory GetTerritoryInfo()
        {
            return _currentUser.Territory;
        }

        public static string GetPhotoLink()
        {
            return _currentUser.PhotoLink;
        }

        public static string GetEmailAddress()
        {
            return _currentUser.EmailAddress;
        }

        public static int GetId()
        {
            return _currentUser.Id;
        }
    }
}

using FriendFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email, string password);
        User GetParticipant(int id);
        int RemoveParticipant(int id);
        int UpdateEmailAddress(int id, string emailaddress);
        int UpdatePhotoLink(int id, string photolink);
        int AddParticipant(string name, string surname, char gender, string dateOfBirth,
            string region, string city, string education, string musicgenre, string moviegenre,
            int smoking, int alcohol, string politicalviews, string photolink, string emailaddress,
            string password, string response);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder.Repositories.Interfaces
{
    public interface IQuestionaryRepository
    {
        int UpdateQuestionary(int userID, string education, string musicgenre,
                    string moviegenre, int smoking, int alcohol, string politicalviews);
    }
}

using System.Collections.Generic;

namespace FriendFinder.Repositories.Interfaces
{
    public interface IFinderRepository
    {
        IEnumerable<int> GetIdsOfTheMostSuitablePersons(int userID, int quantity);
        int GetRandomID(int currentUserID);
    }
}

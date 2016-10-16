using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder.Repositories.Interfaces
{
    public interface ITerritoryRepository
    {
        int UpdateTerritory(int userID, string region, string city);
    }
}

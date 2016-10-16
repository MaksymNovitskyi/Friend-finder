using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        int UpdatePerson(int id, string name, string surname, char gender, string dateOfBirth);
    }
}

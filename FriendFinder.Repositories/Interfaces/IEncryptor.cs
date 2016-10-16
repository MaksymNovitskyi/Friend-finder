using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFinder.Repositories.Interfaces
{
    public interface IEncryptor
    {
        string Encrypt(string password);
    }
}

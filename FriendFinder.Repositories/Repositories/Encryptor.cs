using FriendFinder.Repositories.Interfaces;

namespace FriendFinder.Repositories.Repositories
{    
    //REVIEW TK: It is NOT a REPOSITORY, it should be in your helper folder.
    //Consider 'using System.Text' to reduce code.
    //Consider this class as STATIC.
    public class Encryptor : IEncryptor
    {
        public string Encrypt(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
            //REVIEW TK: return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}

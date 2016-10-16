using FriendFinder.Repositories.Interfaces;

namespace FriendFinder.Repositories.Repositories
{
    public class Encryptor : IEncryptor
    {
        public string Encrypt(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}

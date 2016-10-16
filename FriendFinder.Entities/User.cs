namespace FriendFinder.Entities
{
    public class User
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Territory Territory { get; set; }
        public Questionary Questionary { get; set; }
        public string PhotoLink { get; set; }
        public string EmailAddress { get; set; }
    }
}

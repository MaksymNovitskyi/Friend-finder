namespace FriendFinder.Repositories.Repositories
{
    public abstract class SqlBaseRepository
    {
        protected const string spAddParticipant = "spAddParticipant";
        protected const string spLogin = "spLogin";
        protected const string spGetAllInfoAboutParticipant = "spGetAllInfoAboutParticipant";
        protected const string spRemoveParticipant = "spRemoveParticipant";
        protected const string spUpdatePerson = "spUpdatePerson";
        protected const string spUpdateQuestionary = "spUpdateQuestionary";
        protected const string spUpdateTerritory = "spUpdateTerritory";
        protected const string spUpdateEmailAddress = "spUpdateEmailAddress";
        protected const string spUpdatePhotoLink = "spUpdatePhotoLink";
        protected const string spGetTheMostAppropriate = "spGetTheMostAppropriate";
        protected const string spGetRandomId = "spGetRandomId";


        protected readonly string _connectionString;

        public SqlBaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}

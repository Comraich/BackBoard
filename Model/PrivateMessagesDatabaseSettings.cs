namespace BackBoard.Model
{
    public class PrivateMessagesDatabaseSettings : IPrivateMessagesDatabaseSettings
    {
        public string PrivateMessagesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPrivateMessagesDatabaseSettings
    {
        string PrivateMessagesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
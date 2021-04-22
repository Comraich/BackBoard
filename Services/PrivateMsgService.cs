using BackBoard.Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BackBoard.Services
{
    public class PrivateMsgService
    {
        private readonly IMongoCollection<PrivateMsg> _privateMsgCollection;

        public PrivateMsgService(IPrivateMessagesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _privateMsgCollection = database.GetCollection<PrivateMsg>(settings.PrivateMessagesCollectionName);
        }

        public List<PrivateMsg> Get() =>
            _privateMsgCollection.Find(privateMsg => true).ToList();

        public PrivateMsg Get(string id) =>
            _privateMsgCollection.Find<PrivateMsg>(privateMsg => privateMsg.MessageId.ToString() == id).FirstOrDefault();

        public PrivateMsg Create(PrivateMsg privateMsg)
        {
            _privateMsgCollection.InsertOne(privateMsg);
            return privateMsg;
        }

        public void Update(string id, PrivateMsg privateMsgIn) =>
            _privateMsgCollection.ReplaceOne(privateMsg => privateMsg.MessageId.ToString() == id, privateMsgIn);

        public void Remove(PrivateMsg privateMsgIn) =>
            _privateMsgCollection.DeleteOne(privateMsg => privateMsg.MessageId == privateMsgIn.MessageId);

        public void Remove(string id) => 
            _privateMsgCollection.DeleteOne(privateMsg => privateMsg.MessageId.ToString() == id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BackBoard.Model
{
    public class PrivateMsg
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid MessageId { get; set; }
        
        [BsonElement("Recipient")]
        public Guid Recipent { get; set; }
        public String Payload { get; set; }
        public BsonDateTime MessageDate { get; set; }
    }
}
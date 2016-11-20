using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbCore.Domain
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }

        public ObjectId Id { get; set; }

        [BsonElement(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }
}

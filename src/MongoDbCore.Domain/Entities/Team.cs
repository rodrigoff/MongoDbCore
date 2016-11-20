using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MongoDbCore.Domain.Entities
{
    public class Team : BaseEntity
    {
        [BsonConstructor]
        public Team(string name)
        {
            Name = name;
        }

        [BsonElement(nameof(Name))]
        public string Name { get; set; }

        public ICollection<MongoDBRef> TeamMembers { get; set; }
    }
}

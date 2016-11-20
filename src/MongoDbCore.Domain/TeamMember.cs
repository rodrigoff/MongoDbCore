using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MongoDbCore.Domain
{
    public class TeamMember : BaseEntity
    {
        [BsonConstructor]
        public TeamMember(string name)
        {
            Name = name;
        }

        [BsonElement(nameof(Name))]
        public string Name { get; set; }

        public ICollection<MongoDBRef> Teams { get; set; }
    }
}

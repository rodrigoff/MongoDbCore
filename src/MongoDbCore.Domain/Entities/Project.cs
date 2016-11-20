using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDbCore.Domain.Entities
{
    public class Project : BaseEntity
    {
        [BsonConstructor]
        public Project(string name)
        {
            Name = name;
        }

        [BsonElement(nameof(Name))]
        public string Name { get; set; }

        public MongoDBRef Team { get; set; }
    }
}

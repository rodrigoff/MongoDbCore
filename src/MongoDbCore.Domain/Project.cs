using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbCore.Domain
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
    }
}

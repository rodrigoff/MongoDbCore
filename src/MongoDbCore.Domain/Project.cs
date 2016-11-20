using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbCore.Domain
{

    public class Project : BaseEntity
    {
        [BsonElement(nameof(Name))]
        public string Name { get; set; }
    }
}

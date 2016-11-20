﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbCore.Domain
{
    public class User : BaseEntity
    {
        public User(string username, string name, string email)
        {
            Username = username;
            Name = name;
            Email = email;
        }

        [BsonElement(nameof(Username))]
        public string Username { get; set; }

        [BsonElement(nameof(Name))]
        public string Name { get; set; }

        [BsonElement(nameof(Email))]
        public string Email { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CatMash.Models
{
    public class Cat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("url")]
        public string Image { get; set; }

        [BsonElement("id")]
        public string legacyId { get; set; }

        public double Elo { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace vue_cat_browser_api.Models;

//[BsonIgnoreExtraElements]
public class Cat
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")] public string? Name { get; set; }

    [BsonElement("color")] public string? Color { get; set; }

    [BsonElement("age")] public double Age { get; set; }

    [BsonElement("image")] public string? Image { get; set; }
}
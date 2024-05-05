using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }

    public string Cpf { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Gender { get; set; }

    public bool Premium { get; set; }

    public bool Terms { get; set; }
}
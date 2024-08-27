using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? StudentId { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfJoining { get; set; }
    public bool IsActive { get; set; }
}
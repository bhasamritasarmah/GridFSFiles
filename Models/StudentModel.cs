using MongoDB.Bson.Serialization.Attributes;

namespace Using_GridFS_and_MongoDB.Models
{
	public class StudentModel
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string Id { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
	}
}

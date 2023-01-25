using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Using_GridFS_and_MongoDB.Models;

namespace Using_GridFS_and_MongoDB.Services
{
	public class StudentsService
	{
		private readonly IMongoCollection<StudentModel> _studentsCollection;

		public StudentsService(IOptions<StudentDBSettings> studentDBSettings)
		{
			var mongoClient = new MongoClient(studentDBSettings.Value.ConnectionString);
			var mongoDatabase = mongoClient.GetDatabase(studentDBSettings.Value.DatabaseName);
			_studentsCollection = mongoDatabase.GetCollection<StudentModel>(studentDBSettings.Value.CollectionName);
		}

		public async Task<List<StudentModel>> GetAsync() =>
			await _studentsCollection.Find(s => true).ToListAsync();

		public async Task<StudentModel> GetAsync(string Id) =>
			await _studentsCollection.Find(x => x.Id == Id).FirstOrDefaultAsync();

		public async Task CreateSync(StudentModel newStudent) =>
			await _studentsCollection.InsertOneAsync(newStudent);

		public async Task UpdateAsync(string Id, StudentModel updatedStudent) =>
			await _studentsCollection.ReplaceOneAsync(x => x.Id == Id, updatedStudent);

		public async Task RemoveOneAsync(string Id) =>
			await _studentsCollection.DeleteOneAsync(x => x.Id == Id);
	}
}

using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Using_GridFS_and_MongoDB.Models
{
	public class GridFSInitialisation
	{
		readonly private IMongoDatabase database;

		var bucket = new GridFSBucket(database);
	}
}

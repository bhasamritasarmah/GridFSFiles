using MongoDB.Bson;
using MongoDB.Driver.GridFS;

namespace Using_GridFS_and_MongoDB.Services
{
	public class GridFSDownloads
	{
		IGridFSBucket bucket;
		ObjectId id;

		var bytes = bucket.DownloadAsBytes(id);
	}
}

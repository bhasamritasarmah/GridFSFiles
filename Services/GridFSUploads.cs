using MongoDB.Driver.GridFS;

namespace Using_GridFS_and_MongoDB.Services
{
	public class GridFSUploads
	{
		IGridFSBucket bucket;
		byte[] source;

		var id = bucket.UploadFromBytes("picture1.jpg", source);
	}
}

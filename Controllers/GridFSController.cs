using Microsoft.AspNetCore.Mvc;
using Using_GridFS_and_MongoDB.Models;
using Using_GridFS_and_MongoDB.Services;

namespace Using_GridFS_and_MongoDB.Controllers
{
	public class GridFSController : Controller
	{
		private readonly GridFSUploads _gridFSUploads;

		public class GridFSController(GridFSUploads gridFSUploads)
		{
			_gridFSUploads = GridFSUploads;
		}

		
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(GridFSInitialisation gridFS)
		{
			return View(gridFS);
		}
	}
}

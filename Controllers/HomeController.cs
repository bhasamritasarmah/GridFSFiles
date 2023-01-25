using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Using_GridFS_and_MongoDB.Models;

namespace Using_GridFS_and_MongoDB.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			StudentModel student = new StudentModel();
			student.Name = "Bhasamrita Sarmah";
			student.City = "Tirupati";
			return View(student);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
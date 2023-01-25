using Microsoft.AspNetCore.Mvc;
using Using_GridFS_and_MongoDB.Models;
using Using_GridFS_and_MongoDB.Services;

namespace Using_GridFS_and_MongoDB.Controllers
{
	public class StudentsController : Controller
	{
		private readonly StudentsService _studentsService;

		public StudentsController(StudentsService studentsService)
		{
			_studentsService = studentsService;
		}

		public IActionResult Index()
		{
			return View();
		}   

		[HttpPost]
		public IActionResult Index(StudentModel student)
		{
			string studentId = student.Id;
			string studentName = student.Name;
			string city = student.City;

			return View();
		}
	}
}

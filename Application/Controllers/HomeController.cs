using Application.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Application.Controllers
{
	public class HomeController : Controller
	{
		
		EFContext db;
		public HomeController(EFContext _db)
		{
			db = _db;
		}

		public IActionResult Index()
		{
			//List<Domain.Libraries.library> libraries = db.Librarys.ToList();

			
				return View();
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
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
	public class LibrariesController : Controller
	{
		EFContext db;
		public LibrariesController(EFContext _db)
		{
			db = _db;
		}

		// GET: LibrariesController
		public ActionResult Index()
		{
			Features.Libraries.LibraryFeatures.Queries.LibrariesQuery query = new Features.Libraries.LibraryFeatures.Queries.LibrariesQuery(db);
			List<Domain.Libraries.library> libraries = new List<Domain.Libraries.library>();
			libraries = query.GetAllLibraries();
			if (libraries.Count > 0)
				return Ok(libraries);

			return NotFound();	
		}

		// GET: LibrariesController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: LibrariesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: LibrariesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: LibrariesController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: LibrariesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: LibrariesController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: LibrariesController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}

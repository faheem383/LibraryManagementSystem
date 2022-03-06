using Domain.Libraries;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.LibraryFeatures.Queries
{
	public class LibrariesQuery : ILibrariesQuery
	{
		EFContext db;
		public LibrariesQuery(EFContext _db)
		{
			db = _db;
		}
		public List<library> GetAllLibraries()
		{
			List<Domain.Libraries.library> libraries = db.Librarys.ToList();
			return libraries;
		}

		public library? GetLibraryById(int id)
		{
			return db.Librarys?.FirstOrDefault(lib => lib.Id == id);

		}
	}
}

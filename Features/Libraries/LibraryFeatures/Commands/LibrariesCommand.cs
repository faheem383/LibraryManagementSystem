using Domain.Libraries;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.LibraryFeatures.Commands
{
	public  class LibrariesCommand : ILibrariesCommand
	{
		EFContext db;
		public LibrariesCommand(EFContext _db)
		{
			db = _db;
		}
		public void AddNewLibrary(string name,string address,string phone)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				Domain.Libraries.library library = new Domain.Libraries.library();
				library.Name = name;
				library.Address = address;
				library.Phone = phone;

				db.Librarys.Add(library);
				db.SaveChanges();
			}
		}
	}
}

using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.LibraryFeatures.Queries
{
	public interface  ILibrariesQuery
	{
		
		List<Domain.Libraries.library> GetAllLibraries();
		Domain.Libraries.library GetLibraryById(int id);
	}
}

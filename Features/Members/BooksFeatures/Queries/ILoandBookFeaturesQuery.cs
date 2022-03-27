using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.BooksFeatures.Queries
{
	public interface ILoandBookFeaturesQuery
	{
		public List<Domain.Members.Books.LoandBook> GetLoandBooks();
		public List<Domain.Members.Books.LoandBook> GetLoandBooksByMember(int id);
	}
}

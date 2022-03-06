using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.BooksFeatures.Commands
{
	interface IBooksFeaturesCommand
	{
		void AddCategory(string name);
		public void AddBook(Domain.Libraries.Books.Book book);
		
	}
}

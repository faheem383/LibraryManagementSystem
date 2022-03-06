using Domain.Libraries.Books;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.BooksFeatures.Commands
{
	public class BooksFeaturesCommand : IBooksFeaturesCommand
	{
		EFContext db;
		public BooksFeaturesCommand(EFContext _db)
		{
			db = _db;
		}

		public void AddBook(Book book)
		{
			throw new NotImplementedException();
		}

		public void AddCategory(string name)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				Category category = new Category();
				category.Name = name;
				db.Categories.Add(category);

			}

		}
	}
}

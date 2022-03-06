using Domain.Members.Books;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.BooksFeatures.Commands
{
	public class LoandBookFeaturesCommand : ILoandBookFeaturesCommand
	{
		EFContext db;
		public LoandBookFeaturesCommand(EFContext _db)
		{
			db = _db;
		}
		public void AddNewLoandBook(LoandBook book)
		{
			if (book != null) { 
				db.LoandBook.Add(book);
				db.SaveChanges();
			}
		}

		public void UpdateLondBook(int id, LoandBook book)
		{
			if (id > 0 && book != null)
			{
				Domain.Members.Books.LoandBook loandBook = db.LoandBook.FirstOrDefault(i => i.Id == id);
				if (loandBook != null && loandBook.Id > 0) {
					loandBook = book;
					db.SaveChanges();
				}



			}
		}
	}
}

using Domain.Members.Books;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.BooksFeatures.Queries
{
	public class LoandBookFeaturesQuery : ILoandBookFeaturesQuery
	{
		EFContext db;
		public LoandBookFeaturesQuery(EFContext _db)
		{
			db = _db;
		}
		public List<LoandBook> GetLoandBooks()
		{
			return db.LoandBook.ToList();
		}

		public List<LoandBook> GetLoandBooksByMember(int id)
		{
			return db.LoandBook.Where(c => c.Member.Id == id).ToList();
		}
	}
}

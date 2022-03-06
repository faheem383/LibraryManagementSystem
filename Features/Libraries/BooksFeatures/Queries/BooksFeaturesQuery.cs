using Domain.Libraries.Books;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.BooksFeatures.Queries
{
	public class BooksFeaturesQuery : IBooksFeaturesQuery
	{
		EFContext db;
		public BooksFeaturesQuery(EFContext _db)
		{
			db = _db;
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

		public Author GetAuthor(int id)
		{
			Author author = new Author();
			if (id > 0) {
				author = db.Authors.FirstOrDefault(a => a.Id == id);
			}
			return author;
		}

		public List<Author> GetAuthors()
		{
			return db.Authors.ToList();
		}

		public Book GetBook(int id)
		{
			throw new NotImplementedException();
		}

		public List<Book> GetBooks()
		{
			throw new NotImplementedException();
		}

		public List<Category> GetCategories()
		{
			throw new NotImplementedException();
		}

		public List<PublishHouse> GetPublishHouses()
		{
			throw new NotImplementedException();
		}
	}
}

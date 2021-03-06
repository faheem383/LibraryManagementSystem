using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Libraries.BooksFeatures.Queries
{
	public interface IBooksFeaturesQuery
	{
		List<Domain.Libraries.Books.Book> GetBooks();
		Domain.Libraries.Books.Book GetBook(int id);
		List<Domain.Libraries.Books.Author> GetAuthors();
		Domain.Libraries.Books.Author GetAuthor(int id);
		List<Domain.Libraries.Books.Category> GetCategories();
		List<Domain.Libraries.Books.PublishHouse> GetPublishHouses();



	}
}

using Domain.Libraries.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Libraries.Books
{
	public class Book
	{
		public int Id { get; set; }
		public string BookTitle { get; set; }
		public string ISBN { get; set; }
		public DateTime PublihDate { get; set; }
		public Category Category { get; set; }
		public PublishHouse PublishHouse { get; set; }
		public List<Author> Authors { get; set; }
		public List<Item> BookItems { get; set; }


	}
}

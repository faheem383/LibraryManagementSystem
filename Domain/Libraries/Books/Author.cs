using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Libraries.Books
{
	public  class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }	
		public DateTime? DateofBirth { get; set; }	
		public DateTime? DateofDeath { get; set; }
		List<Book> books {get; set;}

	}
}

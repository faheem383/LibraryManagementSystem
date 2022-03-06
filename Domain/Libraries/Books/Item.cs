using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Libraries.Books
{
	public class Item
	{
		public int Id { get; set; }
		public Book Books { get; set; }
		public library library { get; set; }
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Libraries
{
	public class library
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string? Phone { get; set; }
		public List<Books.Item> BookItems { get; set; }

	}
}

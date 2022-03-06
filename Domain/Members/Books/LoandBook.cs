using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Members.Books
{
	public class LoandBook
	{
		public int Id { get; set; }
		public Users.User Member { get; set; }
		public Libraries.Books.Item BookItem { get; set; }
		public DateTime LoandedDate { get; set; }
		public DateTime DeuDate { get; set; }
		public DateTime ReturnedDate { get; set; }	
		public decimal? Fine {get; set; }
		public int Status {get;set;}
		public string Remarks {get; set;}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Members.Users
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public string Surname{get; set; }
		public string Address{get; set; }	
		public string PostalCode {get; set; }
		public string Phone {get; set; }
		public string? Email{get; set; }
		public int Status {get; set; }

		



	}
}

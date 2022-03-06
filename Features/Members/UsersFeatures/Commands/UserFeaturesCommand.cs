
using Domain.Members.Users;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.UsersFeatures.Commands
{
	public class UserFeaturesCommand : IUserFeaturesCommand
	{
		EFContext db;
		public UserFeaturesCommand(EFContext _db)
		{
			db = _db;
		}
		public void AddUser(User user)
		{
			if (user != null) { 
			  db.Users.Add(user);
				db.SaveChanges();
			}
		}
	}
}

using Domain.Members.Users;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.UsersFeatures.Queries
{
	public class UserFeaturesQuery : IUserFeaturesQuery
	{
		EFContext db;
		public UserFeaturesQuery(EFContext _db)
		{
			db = _db;
		}

		public User GetUser(int id)
		{
			return db.Users.FirstOrDefault(x => x.Id == id);	
		}

		public List<User> GetUsers()
		{
			return db.Users.ToList();
		}
	}
}

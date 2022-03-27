using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.UsersFeatures.Queries
{
	public interface IUserFeaturesQuery
	{
		List<Domain.Members.Users.User> GetUsers();
		Domain.Members.Users.User GetUser(int id);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.UsersFeatures.Commands
{
	public interface IUserFeaturesCommand
	{
		public void AddUser(Domain.Members.Users.User user);	

	}
}

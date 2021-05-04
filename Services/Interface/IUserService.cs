using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamkørsel.Models;

namespace Zamkørsel.Services.Interface
{
	public interface IUserService
	{
		IEnumerable<User> GetAllUsers();
		User AddUser(User u);
	}
}

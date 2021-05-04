using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamkørsel.Models;
using Zamkørsel.Services.Interface;

namespace Zamkørsel.Services.EFServices
{
	public class EFUserService : IUserService
	{
		private readonly AppDbContext _context;
		public EFUserService(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<User> GetAllUsers()
		{
			return _context.Users;
		}

		public User AddUser(User u)
		{
			GetAllUsers().ToList();
			List<int> userIds = new List<int>();
			foreach (var ui in GetAllUsers())
			{
				userIds.Add(ui.UserId);
			}

			if (userIds.Count != 0)
			{
				int start = userIds.Max();
				u.UserId = start + 1;
			}
			else
			{
				u.UserId = 1;
			}

			_context.Users.Add(u);
			_context.SaveChanges();
			return u;
		}
	}
}

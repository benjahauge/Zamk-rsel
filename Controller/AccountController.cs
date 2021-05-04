using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamkørsel.Controller
{
	public class AccountController : Microsoft.AspNetCore.Mvc.Controller
	{
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
	}
}

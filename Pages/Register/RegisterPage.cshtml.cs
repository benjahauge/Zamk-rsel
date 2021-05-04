using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zamkørsel.Models;
using Zamkørsel.Services.Interface;

namespace Zamkørsel.Pages.View
{
    public class RegisterPageModel : PageModel
    {
	    private IUserService _repo;

		[BindProperty]
		public User User { get; set; }

	    public RegisterPageModel(IUserService repo)
	    {
		    _repo = repo;
	    }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
	        if (!ModelState.IsValid)
	        {
		        return Page();
	        }

	        _repo.AddUser(User);
	        return RedirectToPage("Index");
        }
    }
}

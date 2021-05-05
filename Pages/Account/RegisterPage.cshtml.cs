using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zamkørsel.Models;
using Zamkørsel.Services.Interface;
using Zamkørsel.ViewModel;

namespace Zamkørsel.Pages.View
{
    public class RegisterPageModel : PageModel
    {
	    [BindProperty]
		public RegisterViewModel Registration { get; set; }


        public void OnGet()
        {
        }


    }
}

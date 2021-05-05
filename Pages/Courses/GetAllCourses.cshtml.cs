using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zamkørsel.Models;
using Zamkørsel.Services.Interface;

namespace Zamkørsel.Pages.Routes
{
    public class GetAllCoursesModel : PageModel
    {
        public IEnumerable<Course> Courses { get; private set; }

        private ICourseService _repo;

        public GetAllCoursesModel(ICourseService repo)
        {
	        _repo = repo;
        }
        public void OnGet()
        {
	        Courses = _repo.GetAllCourses();
        }
    }
}

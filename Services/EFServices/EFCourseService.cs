using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamkørsel.Models;
using Zamkørsel.Services.Interface;



namespace Zamkørsel.Services.EFServices
{
	public class EFCourseService : ICourseService
	{
		private readonly AppDbContext _context;

		public EFCourseService(AppDbContext context)
		{
			_context = context;
		}


		public IEnumerable<Course> GetAllCourses()
		{
			return _context.Courses;
		}
	}
}

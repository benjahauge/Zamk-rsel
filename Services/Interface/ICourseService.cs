using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamkørsel.Models;

namespace Zamkørsel.Services.Interface
{
	public interface ICourseService
	{
		IEnumerable<Course> GetAllCourses();

	}
}

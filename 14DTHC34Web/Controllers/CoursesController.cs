using _14DTHC34Web.Models;
using _14DTHC34Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace _14DTHC34Web.Controllers
{
    [Authorize(Roles = "Lecturer")]
    public class CoursesController : Controller
    {
        private ApplicationDbContext dbContext;

        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }        
        // Dev1 Dev1 Dev1 Dev1 Dev1 Course Conflict
        //Dev2 Source Code
        //ABC
        public ActionResult CreateCourse()
        {
            var courseViewModel = new CourseViewModel()
            {
                Categories = dbContext.Categories.ToList()
            };
            return View(courseViewModel);
        }
    }
}
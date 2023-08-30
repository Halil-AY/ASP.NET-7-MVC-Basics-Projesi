using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace CourseControllers;
// course
public class CourseController: Controller
{   
    // course
    // course index

    
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            // return Redirect("/course/list");
            return RedirectToAction("List", "Course");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);

    }

    // course list
    public IActionResult List()
    {
      
        return View("CourseList", Repository.Courses);
;    }


}
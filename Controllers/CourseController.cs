using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

// course
public class CourseController: Controller{
    
    // course/index
    //public IActionResult Index()
    //{
        //var kurs = new Course();
        //kurs.Id=1;
        //kurs.Title = "Aspnet core kursu";
        //kurs.Description = "Güzel bir kurs";
        //kurs.Image = "1.jpg";

        

        //return View(kurs);
   // }

    public IActionResult Details(int? id)
    {
        //var kurs = new Course();
        //kurs.Id=1;
        //kurs.Title = "Aspnet core kursu";
        //kurs.Description = "Güzel bir kurs";
        //kurs.Image = "1.jpg";

        if(id==null) {
            return Redirect("/course/list");
        }

        var kurs = Repository.GetById(id);


        return View(kurs);
    }

    // course/list
    public IActionResult List()
    {
        //var kurslar = new List<Course>()
        //{
            //new Course() { Id = 1, Title = "aspnet kursu", Description = "güzel bir kurs", Image="1.jpg"},
            //new Course() { Id = 2, Title = "php kursu", Description = "güzel bir kurs", Image="2.jpg"},
            //new Course() { Id = 3, Title = "django kursu", Description = "güzel bir kurs", Image="3.jpg"},
        //};
        return View("CourseList", Repository.Courses /*kurslar*/);
    }



}
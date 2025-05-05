using Microsoft.AspNetCore.Mvc;
using TeacherAp.Models;

namespace TeacherAp.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var prms = c.Teachers.ToList();
            return View(prms);
        }

        [HttpGet]
        public IActionResult NewTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTeacher(Teacher tr)
        {
            c.Teachers.Add(tr);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTeacher(int id)
        {

            var tchr = c.Teachers.Find(id);
            c.Teachers.Remove(tchr);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetTeacher(int id)
        {
            var tch=c.Teachers.Find(id);    
            return View("GetTeacher",tch);
        }

        public IActionResult UpdateTeacher(Teacher t)
        {
            var tch=c.Teachers.Find(t.TeacherID);
            tch.Name = t.Name;
            tch.Surname = t.Surname;    
            tch.Gender = t.Gender;  
            tch.Subject = t.Subject;    
            tch.Age = t.Age;
            c.SaveChanges();
            return RedirectToAction("Index");   
        }

        public IActionResult AboutApp()
        {
            return View();  
        }
    }
}

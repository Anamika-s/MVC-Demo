using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Methods.cs;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    // CRUD operations 
    public class StudentController : Controller
    {
        ILogger<StudentController> _logger;
        Method _method;
        public StudentController(ILogger<StudentController> logger,
            Method method)
        {
            _logger = logger;   
            _method = method;
        }
        

        public IActionResult Index()
        {
            return View(_method.GetStudents()); 
        }

        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Student student)
        { 
          _method.AddStudent(student);  
            return RedirectToAction("Index");   
        }

        public IActionResult Edit(int? id) {
             Student student = _method.GetStudent(id.Value);
             return View(student);
        }
        [HttpPost]
        public IActionResult Edit(int id, Student student) {
            _method.EditStudent(id, student);
            return RedirectToAction("Index"); 
        }
        public IActionResult Delete(int? id) {
            Student student = _method.GetStudent(id.Value);
            return View(student);
        }

        [HttpPost]
        public IActionResult Deleted(int id)
        {
            _method.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_method.GetStudent(id));
        }
    }
}

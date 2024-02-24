using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class FirstController : Controller
    {
        // Dependency Injection
        ILogger<FirstController> _logger;
        public FirstController(ILogger<FirstController> logger)
        {
            _logger = logger;
        }
            public IActionResult Index()
        {
           
            _logger.LogError("THere is an error");
            _logger.LogInformation("This is an info");

            return View();
        }
    }
}

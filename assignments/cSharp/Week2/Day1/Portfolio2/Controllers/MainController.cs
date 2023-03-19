using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;
    public class MainController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("/projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("/contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }


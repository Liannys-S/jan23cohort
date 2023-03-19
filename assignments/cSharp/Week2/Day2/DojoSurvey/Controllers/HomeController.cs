using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("/survey")]
        public ViewResult Survey(string name, string location, string language, string comment){
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View();
        }
    }
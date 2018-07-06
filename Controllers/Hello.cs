using System;
using Microsoft.AspNetCore.Mvc;
namespace example.Controllers     //be sure to use your own project's namespace!
{
    public class Hello : Controller   //remember inheritance??
    {   
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            // ViewBag.Example = "Hello World";
            return View();
        }
                

        [HttpPost]
        [Route("Results")]
        public IActionResult Results(string fullname, string dojoLocation, string favoriteLanguage,string comments)
        {
            ViewBag.fullname = fullname;
            ViewBag.dojoLocation = dojoLocation;
            ViewBag.favoriteLanguage = favoriteLanguage;
            ViewBag.comments = comments;
                
                
            return View("Results");
        }
    }
}
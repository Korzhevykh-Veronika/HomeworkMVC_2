using Homework_mvc.Entities;
using Homework_mvc.Services;
using System.Web.Mvc;

namespace Homework_mvc.Controllers
{
    public class HomeController : Controller
    {
        MainService mainService = new MainService();

        public HomeController()
        { 
        }

        public ActionResult Index()
        {
            ViewBag.Articles = mainService.GetArticles();

            return View();
        }

        [HttpGet]
        public ActionResult Guest()
        {
            ViewBag.Reviews = mainService.GetReviews();

            return View();
        }
        
        [HttpPost]
        public ActionResult Guest(Review review)
        {
            mainService.CreateReview(review);

            return RedirectToAction("Guest");
        }

        [HttpGet]
        public ActionResult Profile()
        {
            ViewBag.Questions = mainService.GetQuestions();

            return View();            
        }
      
        [HttpPost]
        public ActionResult Profile(User user)
        {
            mainService.CreateUser(user);

            return View("~/Views/Home/Result.cshtml");
        }        
    }
}
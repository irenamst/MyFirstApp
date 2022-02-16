using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;
using System.Diagnostics;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewBag.title="Welcome";
            ViewBag.Name = "Irena Staneva";
            ViewBag.Description = "This is welcome page";
            ViewBag.Contact = "Dear friends, I would like to meet you.";
            ViewBag.Music = "Do you like music?";
            ViewBag.ShaniaTwain = "From this moment on";
            ViewBag.FromThisMoment = "From this moment live has begun. From this moment you are the one. Rigth beside you is where I belong from this moment on." +
                "From this moment I have been blest. I live only for your happiness and for your love I give my last breath.";
            ViewBag.BritneySpears = "Crazy";
            ViewBag.Question = "Do you like this?";
            ViewBag.Text = "Crazy. Baby, I'm so into you. You got that somethin', what can I do?" +
                "Baby, you spin me around. The earth is movin' but I can't feel the ground.";
            return View("Index");
        }

        public IActionResult Privacy()
        {
            ViewBag.Love = "Love";
            ViewBag.LoveYou = "From this moment, I will love you";
            ViewBag.AsLongAsILive = "I will love you as long as I live.";
            ViewBag.FromThisMoment = "From this moment life has begun. From this moment you are the one.";
            ViewBag.Crazy = "(You drive me) crazy.";
            ViewBag.CantSleep = "You drive crazy and I just can't sleep.";
            ViewBag.Excited = "I so excited, I'm into deep.";
            ViewBag.EveryDayAndEveryNigth = "Crazy, but it feels alrigth. Everyday and everynigth. ";
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
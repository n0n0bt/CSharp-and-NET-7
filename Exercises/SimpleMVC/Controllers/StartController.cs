using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            Card myCard = new Card();
            myCard.CardID = 1;
            myCard.Title = "Card Example";
            myCard.Image = "myImg.jpg";
            myCard.Text = "Text example for a template Card. Simple MVC project info.";
            myCard.AlternativeText = "image of a duck";

            return View(myCard);
        }
    }
}

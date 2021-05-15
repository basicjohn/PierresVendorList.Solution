using Microsoft.AspNetCore.Mvc;

namespace PierresVendorList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
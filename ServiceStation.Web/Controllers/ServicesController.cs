using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [ViewData]
        public string PageTitle { get; set; }
        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicleService();
            {
                service.Id = 1;
                service.Title = "Oil chnage";
                service.Description = "Need to chnage oil filter nd oil";
                service.Cost = 100.00;
            }

            return View(service);
        }

    }
}

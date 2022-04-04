using Microsoft.AspNetCore.Mvc;

namespace consume_RestAPI.Controllers
{
    public class ClientsideAPICallController : Controller
    {

        public IActionResult GetRESTDataClient()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

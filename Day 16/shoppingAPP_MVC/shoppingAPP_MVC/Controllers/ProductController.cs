using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shoppingAPP_MVC.Models;
namespace shoppingAPP_MVC.Controllers
{

    [Authorize]
    public class ProductController : Controller
    {

        Products productObj = new Products();
      public IActionResult ProductDetail()
        {
            return View(productObj.GetProducts());
        }

        public IActionResult ProductList()
        {
            ViewBag.developer = "Nikhil";
            ViewBag.teamSize = 23;
            //Session["userid"] = "nik";
           // Application["hits"] = 0;
            return View(productObj.ProductList());
        }
    }
}

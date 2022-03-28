using Microsoft.AspNetCore.Mvc;
using shoppingAPP_MVC.Models;
namespace shoppingAPP_MVC.Controllers
{
    public class ProductController : Controller
    {

        Products productObj = new Products();
      public IActionResult ProductDetail()
        {
            return View(productObj.GetProducts());
        }

        public IActionResult ProductList()
        {
            return View(productObj.ProductList());
        }
    }
}

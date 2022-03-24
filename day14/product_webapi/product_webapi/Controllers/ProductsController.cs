using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using product_webapi.Models;
namespace product_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region First Greet Method
        [HttpGet]
        [Route("greetings")] //encapsulation
        public IActionResult Greet()
        {
            return Ok("Welcome to Web API - RESTFUL Services");
        }
        #endregion

        #region Pass a Parmeter

        [HttpGet]
        [Route("welcomeuser")]
        public IActionResult GreetUser(string guestName)
        {
            return Ok("Welcome : " + guestName);
        }
        #endregion

        #region Return Products Array
        [HttpGet]
        [Route("products")]
        public IActionResult GetProductList()
        {
            string[] products = new string[10];
            products[0] = "Pepsi";
            products[1] = "Coke";
            products[2] = "IPhone";
            products[3] = "Fossil";
            products[4] = "Dell Lattitude";
            products[5] = "Burger";
            products[6] = "Pizza";
            products[7] = "Strawberry Milk Shake";
            products[8] = "Mango Shake";
            products[9] = "Air Pods";
            return Ok(products);
        }
        #endregion

        #region Product Info
        [HttpGet]
        [Route("product")]
        public IActionResult GetProductInformation()
        {
            ProductsModel model = new ProductsModel();
            return Ok(model.GetProductInfo());
        }
        #endregion

        #region Product list
        [HttpGet]
        [Route("plist")]
        public IActionResult ProductList()
        {
            ProductsModel model = new ProductsModel();
            return Ok(model.GetProductlist());
        }

        #endregion

    
    }
}

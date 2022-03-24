using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using product_webapi.Models;
namespace product_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        ProductDetailsModel model = new ProductDetailsModel();

        [HttpGet]
        [Route("plist")]
        public IActionResult Productlist()
        {
            return Ok(model.GetProductList());
        }

        [HttpGet]
        [Route("productdetail")]
        public IActionResult GetproductById(int pid)
        {
            try
            {
                return Ok(model.GetProductDetails(pid));
            }
            catch (System.Exception es)
            {

                return BadRequest(es.Message);
            }
        }


        [HttpPost]
        [Route("addproduct")]
        public IActionResult Addproduct(ProductDetailsModel newProduct)
        {
            try
            {
                return Created("", model.Addproduct(newProduct));
            }
            catch (System.Exception es)
            {
                return BadRequest(es.Message);
            }

        }

        [HttpDelete]
        [Route("deleteproduct")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                return Accepted(model.DeleteProduct(id));
            }
            catch (System.Exception es)
            {
                return BadRequest(es.Message);
            }
        }


        [HttpPut]
        [Route("updateproduct")]
        public IActionResult UpdateProduct(ProductDetailsModel updates)
        {
            try
            {
                return Accepted(model.UpdateProduct(updates));
            }
            catch (System.Exception es)
            {

                return BadRequest(es.Message);
            }
        }
            
    }
}








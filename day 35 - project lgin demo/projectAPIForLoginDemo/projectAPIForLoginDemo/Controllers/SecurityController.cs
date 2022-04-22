using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectAPIForLoginDemo.Models.EF;
namespace projectAPIForLoginDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        toptypersDBContext dbContext = new toptypersDBContext();

        [HttpGet]
        [Route("login/{email}/{password}")]
        public IActionResult CheckLogin(string email, string password)
        {
            #region Return only true or false
            //var checkLogin = (from e in dbContext.LoginTables
            //                  where e.Email == email && e.AccountPassword == password
            //                  select e).Count();

            //if (checkLogin > 0)
            //{
            //    return Ok(true);
            //}
            //else
            //{
            //    return BadRequest(false);
            //}
            #endregion


            var details = (from e in dbContext.LoginTables
                          where e.Email == email && e.AccountPassword == password
                          select new
                          {
                              e.FirstName,
                              e.LastName,
                              e.Email,
                              e.IsAdmin
                          }).SingleOrDefault();
            if (details != null)
            {
                return Ok(details);
            }
            else
            {
                return NoContent();
            }
        }
    }
}

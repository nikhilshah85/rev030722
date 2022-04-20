using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectRestAPI.Models.EF;
namespace projectRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        projectdemoDBContext dbContext = new projectdemoDBContext();


        [HttpGet]
        [Route("elist")]
        public IActionResult GetEmployeelist()
        {
            var empList = from e in dbContext.Employees
                          select e;
            return Ok(empList);
        }

        [HttpGet]
        [Route("emp/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
          

            try
            {
                var emp = (from e in dbContext.Employees
                           where e.EmpNo == id
                           select e).SingleOrDefault();

                if (emp != null)
                {
                    return Ok(emp);
                }
                else
                {
                    return NotFound("Employee Not found in system");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteEmployeeById(int id)
        {
            var emp = (from e in dbContext.Employees
                      where e.EmpNo == id
                      select e).SingleOrDefault();


            if (emp != null)
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return Accepted("", "Employee Deleted Successfully from the system");
            }
            else
            {
                return NotFound("Employee Not found in system");
            }
        }


        [HttpPost]
        [Route("add")]
        public IActionResult AddEmployee(Employee newEmp)
        {
            if (newEmp == null)
            {
                dbContext.Employees.Add(newEmp);
                dbContext.SaveChanges();
                return Created("", "Employee Added Successfully");
            }
            else
                return BadRequest("Something went wrng");

        }
         

        [HttpPut]
        [Route("edit")]
        public IActionResult EditEmployee(Employee changes)
        {
            var emp = (from e in dbContext.Employees
                       where e.EmpNo == changes.EmpNo
                       select e).SingleOrDefault();
            if(emp != null)
            {
                emp.EmpName = changes.EmpName;
                emp.EmpDesignation = changes.EmpDesignation;
                emp.EmpAge = changes.EmpAge;
                emp.EmpDept = changes.EmpDept;
                dbContext.SaveChanges();
                return Ok("Changes done");
            }
            else
            {
                return BadRequest("Something went wrong");
            }

        }


    }
}

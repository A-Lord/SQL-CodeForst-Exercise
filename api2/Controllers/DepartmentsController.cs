using Microsoft.AspNetCore.Mvc;
using Service;
using API.DTO;
using Store.Models;


namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentsController : Controller
    {
        
       [HttpGet]
       public IActionResult DepartmentOwners()
        {
            try
            {
                var result = new List<DepartmentsDTO>();
                foreach (var item in DepartmentsService.Instance.DepartmentsList())
                {
                    result.Add(new DepartmentsDTO()
                    {
                        Name = item.Key,
                        mail = item.Value
                    }
                    );
                   
                }
                
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        
    }
}

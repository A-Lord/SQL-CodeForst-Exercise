using API.DTO;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace API.Controllers
{
    [Route("employees")]
    [ApiController]
    public class StaffController : Controller
    {
        [HttpGet]
        public IActionResult StaffList()
        {
            try
            {
                var StaffList = new List<StaffDTO>();
                int count = 0;
                foreach (var item in StaffService.Instance.StaffList())
                {
                    count++;
                    StaffList.Add(new StaffDTO()
                    {
                        Name = item.Key,
                        IsDepartmentOwner = item.Value
                    });

                }
                var result = new StaffListDTO()
                {
                    EmployeeCount = count,
                    EmployeeList = StaffList
                };
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}

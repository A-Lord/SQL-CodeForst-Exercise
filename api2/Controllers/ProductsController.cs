using API.DTO;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet("count")]
        public IActionResult Count()
        {
            try
            {
                var result = new List<ProductsDTO>();
                foreach (var products in ProductsService.Instance.ListAllProducts())
                {
                    result.Add(
                        new ProductsDTO()
                        {
                            Name = products.Name,
                            Stock = products.stock,
                            Status = ProductsService.Instance.UpdateStatus(products.stock)
                        });

                }
                result = result.OrderBy(x => x.Stock).ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpPost("update")]
        public IActionResult Update(int ArticleNumber, int NewCount)
        {
            try
            {
                ProductsService.Instance.UpdateStock(ArticleNumber, NewCount);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }


        }
        [HttpPost("List")]
        public IActionResult ProductList(string department, int count)
        {
            try
            {
                var result = new List<ProductsDTO>();
                foreach (var products in ProductsService.Instance.ProductList(department, count))
                {
                    result.Add(
                        new ProductsDTO()
                        {
                            Name = products.Name,
                            Stock = products.stock,
                            Status = ProductsService.Instance.UpdateStatus(products.stock)

                        });
                }
                if (result.Count == 0)
                {
                    return NotFound();
                }
                result = result.OrderBy(x => x.Stock).ToList();
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }



    }
}

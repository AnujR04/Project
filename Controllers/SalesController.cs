using Microsoft.AspNetCore.Mvc;
using Project.MyProject.BLL;
using Project.MyProject.DAL;



namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _saleService;

        public SalesController(ISalesService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sales>> GetSale(int id)
        {
            var sale = await _saleService.GetSaleAsync(id);
            if (sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }

        [HttpPost]
        public async Task<ActionResult<Sales>> PostSale(Sales sale)
        {
            var newSale = await _saleService.CreateSaleAsync(sale);
            return CreatedAtAction(nameof(GetSale), new { id = newSale.SalesId }, newSale);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(int id, Sales sale)
        {
            try
            {
                await _saleService.UpdateSaleAsync(id, sale);
            }
            catch (ArgumentException)
            {
                return BadRequest("Sale ID mismatch");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            await _saleService.DeleteSaleAsync(id);
            return NoContent();
        }
    }
}

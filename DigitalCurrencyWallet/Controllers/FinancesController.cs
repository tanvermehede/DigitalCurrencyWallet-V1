using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DigitalCurrencyWallet.Databases;
using DigitalCurrencyWallet.Models;

namespace DigitalCurrencyWallet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public FinancesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Finances
        [HttpGet]
        public IEnumerable<Finance> GetFinance()
        {
            return _context.Finance;
        }

        // GET: api/Finances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFinance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var finance = await _context.Finance.FindAsync(id);

            if (finance == null)
            {
                return NotFound();
            }

            return Ok(finance);
        }

        // PUT: api/Finances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFinance([FromRoute] int id, [FromBody] Finance finance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != finance.Id)
            {
                return BadRequest();
            }

            _context.Entry(finance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinanceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Finances
        [HttpPost]
        public async Task<IActionResult> PostFinance([FromBody] Finance finance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Finance.Add(finance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinance", new { id = finance.Id }, finance);
        }

        // DELETE: api/Finances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var finance = await _context.Finance.FindAsync(id);
            if (finance == null)
            {
                return NotFound();
            }

            _context.Finance.Remove(finance);
            await _context.SaveChangesAsync();

            return Ok(finance);
        }

        private bool FinanceExists(int id)
        {
            return _context.Finance.Any(e => e.Id == id);
        }
    }
}
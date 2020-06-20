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
    public class GiveOffersController : ControllerBase
    {
        private readonly MyDbContext _context;

        public GiveOffersController(MyDbContext context)
        {
            _context = context;
        }

        // POST: api/GiveOffers
        [HttpPost]
        public async Task<IActionResult> PostGiveOffer([FromBody] GiveOffer giveOffer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GiveOffer.Add(giveOffer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGiveOffer", new { id = giveOffer.Id }, giveOffer);
        }

        private bool GiveOfferExists(int id)
        {
            return _context.GiveOffer.Any(e => e.Id == id);
        }
    }
}
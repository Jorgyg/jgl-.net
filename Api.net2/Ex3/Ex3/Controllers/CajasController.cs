using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ex3.Models;

namespace Ex3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CajasController : ControllerBase
    {
        private readonly APIContext _context;

        public CajasController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Cajas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caja>>> GetCajas()
        {
          if (_context.Cajas == null)
          {
              return NotFound();
          }
            return await _context.Cajas.ToListAsync();
        }

        // GET: api/Cajas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caja>> GetCaja(int id)
        {
          if (_context.Cajas == null)
          {
              return NotFound();
          }
            var caja = await _context.Cajas.FindAsync(id);

            if (caja == null)
            {
                return NotFound();
            }

            return caja;
        }

        // PUT: api/Cajas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaja(int id, Caja caja)
        {
            if (id != caja.NumReferncia)
            {
                return BadRequest();
            }

            _context.Entry(caja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CajaExists(id))
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

        // POST: api/Cajas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caja>> PostCaja(Caja caja)
        {
          if (_context.Cajas == null)
          {
              return Problem("Entity set 'APIContext.Cajas'  is null.");
          }
            _context.Cajas.Add(caja);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaja", new { id = caja.NumReferncia }, caja);
        }

        // DELETE: api/Cajas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaja(int id)
        {
            if (_context.Cajas == null)
            {
                return NotFound();
            }
            var caja = await _context.Cajas.FindAsync(id);
            if (caja == null)
            {
                return NotFound();
            }

            _context.Cajas.Remove(caja);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CajaExists(int id)
        {
            return (_context.Cajas?.Any(e => e.NumReferncia == id)).GetValueOrDefault();
        }
    }
}

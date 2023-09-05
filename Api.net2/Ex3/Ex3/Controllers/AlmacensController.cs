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
    public class AlmacensController : ControllerBase
    {
        private readonly APIContext _context;

        public AlmacensController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Almacens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Almacen>>> GetAlmacenes()
        {
          if (_context.Almacenes == null)
          {
              return NotFound();
          }
            return await _context.Almacenes.ToListAsync();
        }

        // GET: api/Almacens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Almacen>> GetAlmacen(int id)
        {
          if (_context.Almacenes == null)
          {
              return NotFound();
          }
            var almacen = await _context.Almacenes.FindAsync(id);

            if (almacen == null)
            {
                return NotFound();
            }

            return almacen;
        }

        // PUT: api/Almacens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmacen(int id, Almacen almacen)
        {
            if (id != almacen.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(almacen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmacenExists(id))
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

        // POST: api/Almacens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Almacen>> PostAlmacen(Almacen almacen)
        {
          if (_context.Almacenes == null)
          {
              return Problem("Entity set 'APIContext.Almacenes'  is null.");
          }
            _context.Almacenes.Add(almacen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlmacen", new { id = almacen.Codigo }, almacen);
        }

        // DELETE: api/Almacens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlmacen(int id)
        {
            if (_context.Almacenes == null)
            {
                return NotFound();
            }
            var almacen = await _context.Almacenes.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }

            _context.Almacenes.Remove(almacen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmacenExists(int id)
        {
            return (_context.Almacenes?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}

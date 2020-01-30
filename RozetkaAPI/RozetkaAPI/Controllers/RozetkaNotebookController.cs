using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RozetkaAPI.Model;

namespace RozetkaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RozetkaNotebookController : ControllerBase
    {
        private readonly RozetkaNotebookContext _context;

        public RozetkaNotebookController(RozetkaNotebookContext context)
        {
            _context = context;
        }

        // GET: api/RozetkaNotebook
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RozetkaNotebook>>> GetRozetkaNotebooks()
        {
            return await _context.RozetkaNotebooks.ToListAsync();
        }

        [HttpGet("manufacture")]
        public async Task<ActionResult<IEnumerable<Manufacture>>> GetRozetkaNotebooksManufacture()
        {
            var rozetkaNotebook = await _context.RozetkaNotebooks.ToListAsync();
            var result = (from x in rozetkaNotebook
                          orderby x
                          select new Manufacture
                          {
                              NotebookManufacture = x.NotebookManufacture,
                              @checked = false
                          }).ToList();
            return result;
        }

        // GET: api/RozetkaNotebook/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RozetkaNotebook>> GetRozetkaNotebook(int id)
        {
            var rozetkaNotebook = await _context.RozetkaNotebooks.FindAsync(id);

            if (rozetkaNotebook == null)
            {
                return NotFound();
            }

            return rozetkaNotebook;
        }

        // PUT: api/RozetkaNotebook/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRozetkaNotebook(int id, RozetkaNotebook rozetkaNotebook)
        {
            if (id != rozetkaNotebook.NotebookID)
            {
                return BadRequest();
            }

            _context.Entry(rozetkaNotebook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RozetkaNotebookExists(id))
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

        // POST: api/RozetkaNotebook
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RozetkaNotebook>> PostRozetkaNotebook(RozetkaNotebook rozetkaNotebook)
        {
            _context.RozetkaNotebooks.Add(rozetkaNotebook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRozetkaNotebook", new { id = rozetkaNotebook.NotebookID }, rozetkaNotebook);
        }

        // DELETE: api/RozetkaNotebook/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RozetkaNotebook>> DeleteRozetkaNotebook(int id)
        {
            var rozetkaNotebook = await _context.RozetkaNotebooks.FindAsync(id);
            if (rozetkaNotebook == null)
            {
                return NotFound();
            }

            _context.RozetkaNotebooks.Remove(rozetkaNotebook);
            await _context.SaveChangesAsync();

            return rozetkaNotebook;
        }

        private bool RozetkaNotebookExists(int id)
        {
            return _context.RozetkaNotebooks.Any(e => e.NotebookID == id);
        }
    }
}

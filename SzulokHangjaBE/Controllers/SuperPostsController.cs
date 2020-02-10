using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Models.UserPosts;

namespace SzulokHangjaBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperPostsController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;

        public SuperPostsController(SzulokHangjaBEContext context)
        {
            _context = context;
        }

        // GET: api/SuperPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuperPost>>> GetSuperPost()
        {
            return await _context.SuperPost.ToListAsync();
        }

        // GET: api/SuperPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperPost>> GetSuperPost(Guid id)
        {
            var superPost = await _context.SuperPost.FindAsync(id);

            if (superPost == null)
            {
                return NotFound();
            }

            return superPost;
        }

        // PUT: api/SuperPosts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuperPost(Guid id, SuperPost superPost)
        {
            if (id != superPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(superPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuperPostExists(id))
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

        // POST: api/SuperPosts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SuperPost>> PostSuperPost(SuperPost superPost)
        {
            _context.SuperPost.Add(superPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuperPost", new { id = superPost.Id }, superPost);
        }

        // DELETE: api/SuperPosts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperPost>> DeleteSuperPost(Guid id)
        {
            var superPost = await _context.SuperPost.FindAsync(id);
            if (superPost == null)
            {
                return NotFound();
            }

            _context.SuperPost.Remove(superPost);
            await _context.SaveChangesAsync();

            return superPost;
        }

        private bool SuperPostExists(Guid id)
        {
            return _context.SuperPost.Any(e => e.Id == id);
        }
    }
}

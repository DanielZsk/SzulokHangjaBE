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
    [Route("api/")]
    [ApiController]
    public class ParentPostsController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;

        public ParentPostsController(SzulokHangjaBEContext context)
        {
            _context = context;
        }

        // GET: api/ParentPosts
        [HttpGet("ListAllParentPosts")]
        public async Task<ActionResult<IEnumerable<ParentPost>>> GetAllParentPosts()
        {
            return await _context.ParentPost.ToListAsync();
        }

        [HttpGet("getparentat/")]
        public async Task<ActionResult<List<ParentPost>>> getXparentpost(string x, string y)
        {
            string loc = Request.Query["searchparam"];

            Queries.findby(searchparam)

            var mylist = await _context.ParentPost.ToListAsync<ParentPost>();
            return mylist.Where(post => post.Location.ToLower() == x).ToList();
        }

        // GET: api/ParentPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParentPost>> GetParentPost(Guid id)
        {
            var parentPost = await _context.ParentPost.FindAsync(id);

            if (parentPost == null)
            {
                return NotFound();
            }

            return parentPost;
        }

        // PUT: api/ParentPosts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParentPost(Guid id, ParentPost parentPost)
        {
            if (id != parentPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(parentPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParentPostExists(id))
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

        // POST: api/ParentPosts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ParentPost>> PostParentPost(ParentPost parentPost)
        {
            _context.ParentPost.Add(parentPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParentPost", new { id = parentPost.Id }, parentPost);
        }

        // DELETE: api/ParentPosts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ParentPost>> DeleteParentPost(Guid id)
        {
            var parentPost = await _context.ParentPost.FindAsync(id);
            if (parentPost == null)
            {
                return NotFound();
            }

            _context.ParentPost.Remove(parentPost);
            await _context.SaveChangesAsync();

            return parentPost;
        }

        private bool ParentPostExists(Guid id)
        {
            return _context.ParentPost.Any(e => e.Id == id);
        }
    }
}

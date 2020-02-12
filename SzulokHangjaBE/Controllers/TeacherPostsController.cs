using System;
using System.Collections.Generic;
using System.IO;
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
    public class TeacherPostsController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;

        public TeacherPostsController(SzulokHangjaBEContext context)
        {
            _context = context;
        }

        // GET: api/TeacherPosts

        [HttpGet("teacherpostsall")]
        public async Task<ActionResult<IEnumerable<TeacherPostRecommendation>>> GetTeacherPost()
        {
            return await _context.TeacherPostRecommendation.ToListAsync();
        }
        [Route("teach2")]
        [HttpGet]
        public async Task<List<TeacherPostRecommendation>> GetTeacherPost2()
        {
            var list = await _context.TeacherPostRecommendation.ToListAsync();
            return list;
        }

        // GET: api/TeacherPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherPostRecommendation>> GetTeacherPost(Guid id)
        {
            var teacherPost = await _context.TeacherPostRecommendation.FindAsync(id);

            if (teacherPost == null)
            {
                return NotFound();
            }

            return teacherPost;
        }

        // PUT: api/TeacherPosts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacherPost(Guid id, TeacherPostRecommendation teacherPost)
        {
            if (id != teacherPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacherPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherPostExists(id))
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

        // POST: api/TeacherPosts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TeacherPostRecommendation>> PostTeacherPost(TeacherPostRecommendation teacherPost)
        {
            _context.TeacherPostRecommendation.Add(teacherPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacherPost", new { id = teacherPost.Id }, teacherPost);
        }

        // DELETE: api/TeacherPosts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherPostRecommendation>> DeleteTeacherPost(Guid id)
        {
            var teacherPost = await _context.TeacherPostRecommendation.FindAsync(id);
            if (teacherPost == null)
            {
                return NotFound();
            }

            _context.TeacherPostRecommendation.Remove(teacherPost);
            await _context.SaveChangesAsync();

            return teacherPost;
        }

        private bool TeacherPostExists(Guid id)
        {
            return _context.TeacherPostRecommendation.Any(e => e.Id == id);
        }
    }
}

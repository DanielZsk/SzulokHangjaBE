using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Models.UserPosts;
using SzulokHangjaBE.Services;

namespace SzulokHangjaBE.Controllers
{
    [Route("api/teachersal")]
    [ApiController]
    public class TeacherPostSalariesController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;
        private FilterPosts<TeacherPostSalary> DB { get; set; }

        public TeacherPostSalariesController(SzulokHangjaBEContext context)
        {
            _context = context;
            DB = new FilterPosts<TeacherPostSalary>(_context.TeacherPostSalary,_context);
        }


        // GET: api/teachersal/listall
        [HttpGet("listall")]
        public async Task<ActionResult<IEnumerable<TeacherPostSalary>>> GetTeacherRecommendation()
        {
            return await DB.ListAll();
        }


        // GET: api/teachersal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherPostSalary>> GetTeacherPostSalary(Guid id)
        {
            var teacherPost = await DB.SearchById(id);

            if (teacherPost == null)
            {
                return NotFound();
            }

            return teacherPost;
        }

        // POST: api/teachersal/add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("add")]
        public async Task<ActionResult<TeacherPostSalary>> PostTeacherPostSalary(TeacherPostSalary teacherPost)
        {
            var response = await DB.Add(teacherPost);
            if (response == "OK") { return CreatedAtAction("GetTeacherPostSalary", new { id = teacherPost.Id }, teacherPost); }

            return NotFound();
        }


        private bool TeacherPostSalaryExists(Guid id)
        {
            return _context.TeacherPostSalary.Any(e => e.Id == id);
        }
    }
}

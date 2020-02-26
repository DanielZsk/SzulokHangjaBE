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
using SzulokHangjaBE.Services;

namespace SzulokHangjaBE.Controllers
{
    [Route("api/teacherrec/")]
    [ApiController]
    public class TeacherPostRecommendationController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;
        private FilterPosts<TeacherPostRecommendation> DB { get; set; }


        public TeacherPostRecommendationController(SzulokHangjaBEContext context)
        {
            _context = context;
            DB = new FilterPosts<TeacherPostRecommendation>(_context);

        }

        // GET: api/teacherrec/listall

        [HttpGet("listall")]
        public async Task<ActionResult<IEnumerable<TeacherPostRecommendation>>> GetTeacherRecommendation()
        {
            return await DB.ListAll();
        }

        // GET: api/teacherrec/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherPostRecommendation>> GetTeacherPost(Guid id)
        {

            var teacherPost = await DB.SearchById(id);

            if (teacherPost == null)
            {
                return NotFound();
            }

            return teacherPost;
        }


        // POST: api/teacherrec/add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("add")]
        public async Task<ActionResult<TeacherPostRecommendation>> PostTeacherPost(TeacherPostRecommendation teacherPost)
        {
            var response = await DB.Add(teacherPost);
            if (response == "OK") { return CreatedAtAction("GetTeacherPostSalary", new { id = teacherPost.Id }, teacherPost); }

            return NotFound();
        }

        [HttpGet("filter")]
        public async Task<ActionResult<List<TeacherPostRecommendation>>> FilterBy()
        {
            var parameter = Request.Query["parameter"];
            var field = Request.Query["field"];
            var result = await DB.FilterBy(field, parameter.ToString());
            return result;

        }


        private bool TeacherPostExists(Guid id)
        {
            return _context.TeacherPostRecommendation.Any(e => e.Id == id);
        }
    }
}

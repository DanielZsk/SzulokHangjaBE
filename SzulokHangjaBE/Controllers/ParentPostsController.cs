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
    [Route("api/parent/")]
    [ApiController]
    public class ParentPostsController : ControllerBase
    {
        private readonly SzulokHangjaBEContext _context;
        private FilterPosts<ParentPost> DB { get; set; }

        public ParentPostsController(SzulokHangjaBEContext context)
        {
            _context = context;
            DB = new FilterPosts<ParentPost>(_context.ParentPost, _context);
        }

        // GET: api/ParentPosts
        [HttpGet("listall")]
        public async Task<ActionResult<IEnumerable<ParentPost>>> GetAllParentPosts()
        {
            return await DB.ListAll();
            
        }

        [HttpGet("filter")]
        public async Task<ActionResult<List<ParentPost>>> filter()
        {
            var parameter = Request.Query["parameter"];
            var field = Request.Query["field"];
            var result = await DB.FilterBy(field, parameter.ToString());
            return result;

        }

        // GET: api/ParentPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParentPost>> GetParentPost(Guid id)
        {
            var parentpost = await DB.SearchById(id);

            if (parentpost == null)
            {
                return NotFound();
            }

            return parentpost;
        }



        // POST: api/ParentPosts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("add")]
        public async Task<ActionResult<ParentPost>> PostTeacherPost(ParentPost parentpost)
        {
            var response = await DB.Add(parentpost);
            if (response == "OK") { return CreatedAtAction("GetTeacherPostSalary", new { id = parentpost.Id }, parentpost); }

            return NotFound();
        }

        private bool ParentPostExists(Guid id)
        {
            return _context.ParentPost.Any(e => e.Id == id);
        }
    }
}

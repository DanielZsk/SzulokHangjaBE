using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Models.UserPosts;

namespace SzulokHangjaBE.Services
{
    public class FilterPosts<T> where T : class
    {
        private readonly SzulokHangjaBEContext _context;
        private DbSet<T> _db;

        public FilterPosts(DbSet<T> db, SzulokHangjaBEContext context)
        {
            _db = db;
            _context = context;
        }

        public async Task<ActionResult<T>> SearchById(Guid id)
        {
            return await _db.FindAsync(id);
        }

        public async Task<ActionResult<IEnumerable<T>>> ListAll()
        {
            return await _db.ToListAsync();
        }

        public async Task<string> Add(T record)
        {
            try
            {
                _db.Add(record);
                await _context.SaveChangesAsync();
                return "OK";
            }
            catch { }
            return "NOT OK";
        }

        public async Task<List<T>> FilterBy(string field, string parameter)
        {
            //var result = from item in _db
            //             where item.GetType().GetProperty(field).GetValue(item) == parameter
            //             select item;
            bool Abc(T item)
            {
                var a = typeof(T).GetProperty(field);
                var b = a.GetValue(item).ToString().ToLower();
                return b == parameter;
            }

            //Expression<Func<T, bool>> predicate = item => (string)typeof(T).GetProperty(field).GetValue(item) == parameter;
            List<T> result = _db.Where(Abc).ToList();

            return result.ToList();
        }

       

       
    }
}


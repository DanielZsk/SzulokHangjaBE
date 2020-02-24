using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Models.UserPosts;
using System.Reflection;

namespace SzulokHangjaBE.Services
{
    public class FilterPosts<T> where T : class
    {
        private readonly SzulokHangjaBEContext _context;
        private DbSet<T> _db;
        private Dictionary<string, string> _dbmapper = new Dictionary<string, string>() {
            { "SzulokHangjaBE.Models.UserPosts.ParentPost","ParentPost" },
            {"TeacherPostRecommendation", "TeacherPostRecommendation" },
            {"TeacherPostSalary", "TeacherPostSalary" }
        };

        public FilterPosts(DbSet<T> db, SzulokHangjaBEContext context)
        {
           // _db = db;
            _context = context;
            CreateContext();
        }

        private void CreateContext()
        {

            //1 Megoldas - DO NOT DELETE PLEASE ( creates a copy with reflection)
            //string typeofcls = _dbmapper[typeof(T).ToString()];
            //var proprty = _context.GetType().GetProperty(typeofcls);
            //string pName = proprty.Name; // pl ParentPost NAme
            //ez hozzafer  a nev alapjan a context propertijehez
            //var bena = _context.GetType().GetProperty(pName).GetValue(_context);
            //_db = Convert.ChangeType(new object(), propertyType);
            //_db = aa;

            //2. Megoldas
            _db = (DbSet<T>)_context.GetType().GetMethod("Set").MakeGenericMethod(typeof(T)).Invoke(_context, null);
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

        public async Task<ActionResult<List<T>>> FilterBy(string field, string parameter)
        {
            ////First letter capitalizer, useless for 2word properties, e.g. SubmissionDate
            //field = field.First().ToString().ToUpper() + field.Substring(1);
            var propName = typeof(T).GetProperty(field);

            bool FieldValuePredicate(T item)
            {
                var b = propName.GetValue(item).ToString().ToLower();
                return b == parameter;
            }
            //List<T> result = _db.Where(FieldValuePredicate).ToList();
            //return result.ToList();

            return _db.AsEnumerable().Where(item => propName.GetValue(item).ToString().ToLower() == parameter).ToList();
           // return _db.Where(item => 12434.ToString().ToLower() == parameter).ToList();
        }



    }
}


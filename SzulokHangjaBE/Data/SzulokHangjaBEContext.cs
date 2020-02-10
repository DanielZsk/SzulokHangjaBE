using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SzulokHangjaBE.Models.UserPosts;

namespace SzulokHangjaBE.Data
{
    public class SzulokHangjaBEContext : DbContext
    {
        public SzulokHangjaBEContext (DbContextOptions<SzulokHangjaBEContext> options)
            : base(options)
        {
        }

        public DbSet<SzulokHangjaBE.Models.UserPosts.SuperPost> SuperPost { get; set; }

        public DbSet<SzulokHangjaBE.Models.UserPosts.ParentPost> ParentPost { get; set; }

        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPost> TeacherPost { get; set; }
    }
}

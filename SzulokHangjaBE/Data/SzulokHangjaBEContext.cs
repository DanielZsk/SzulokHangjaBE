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
        public DbSet<SzulokHangjaBE.Models.UserPosts.ParentPost> ParentPost { get; set; }

        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPost> TeacherPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "ParentPost1", ReviewTopic = "Eszkoztar", ReviewType = false, Title = "Szarok a padok a suliban", Text = "nezzetek ma milyen fikas a pad", AgeOfChild = 8 });
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "ParentPost2", ReviewTopic = "NAT", ReviewType = true, Title = "Szuper jo az uj irodalom tanterv", Text = "vegre olvassak mar a 50shds of greyt altalanosban", AgeOfChild = 13 });

            modelBuilder.Entity<TeacherPost>().HasData(new TeacherPost() { Id = Guid.NewGuid(), Location = "TeacherPost", ReviewTopic = "NAT", ReviewType = true, Title = "Szuper jo az uj irodalom tanterv", Text = "vegre olvassak mar a 50shds of greyt altalanosban", Salary = 1333333 });
        }
    }
}

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

        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPostRecommendation> TeacherPostRecommendation { get; set; }
        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPostSalary> TeacherPostSalary { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Budapest",  Message = "Ninncs helyettesítés betegség idején", PositiveMessage=false,CommentType=Models.CommentType.MATERIAL});
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Vas",  Message = "Szuper jo az uj irodalom tanterv", PositiveMessage=true, CommentType = Models.CommentType.PERSONAL });

            modelBuilder.Entity<TeacherPostRecommendation>().HasData(new TeacherPostRecommendation() { Id = Guid.NewGuid(), Location = "Zala", Name="Maris",  Recommendation = "Több szabadságot a tanároknak"});
            modelBuilder.Entity<TeacherPostSalary>().HasData(new TeacherPostSalary() { Id = Guid.NewGuid(), Location = "Bekes", Name = "Ili",  Experience = "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", Workload= "Heti 38 óra plusz helyettesítések", Salary = 250000});
            modelBuilder.Entity<TeacherPostSalary>().HasData(new TeacherPostSalary() { Id = Guid.NewGuid(), Location = "Pjost", Name = "Zsuzs", Experience = "10 éve tanítok irodalmat és történelmet", Workload = "Heti 38 óra plusz helyettesítések", Salary = 2232323 });
        }
    }
}

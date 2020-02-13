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
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Budapest", SubmissionDate= DateTime.Now, Message = "Ninncs helyettesítés betegség idején", PositiveMessage=false,CommentType=Models.CommentType.MATERIAL});
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Vas", SubmissionDate = DateTime.Now, Message = "Szuper jo az uj irodalom tanterv", PositiveMessage=true, CommentType = Models.CommentType.PERSONAL });

            modelBuilder.Entity<TeacherPostRecommendation>().HasData(new TeacherPostRecommendation() { Id = Guid.NewGuid(), Location = "Zala", Name="Maris", SubmissionDate = DateTime.Now, Recommendation = "Több szabadságot a tanároknak"});
            modelBuilder.Entity<TeacherPostSalary>().HasData(new TeacherPostSalary() { Id = Guid.NewGuid(), Location = "Bekes", Name = "Ili", SubmissionDate = DateTime.Now, Experience = "10 éve tanítok irodalmat és történelmet", Workload= "Heti 38 óra plusz helyettesítések", Salary = 250000});
        }
    }
}

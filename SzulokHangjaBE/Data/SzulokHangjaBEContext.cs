using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SzulokHangjaBE.Models.UserPosts;

namespace SzulokHangjaBE.Data
{
    public class SzulokHangjaBEContext : IdentityDbContext
    {
        public SzulokHangjaBEContext (DbContextOptions<SzulokHangjaBEContext> options)
            : base(options)
        {
        }
        public DbSet<SzulokHangjaBE.Models.UserPosts.ParentPost> ParentPost { get; set; }

        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPostRecommendation> TeacherPostRecommendation { get; set; }
        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPostSalary> TeacherPostSalary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseLoggerFactory(MyLoggerFactory) // Warning: Do not create a new ILoggerFactory instance each time
        .UseSqlServer(
           "Server=(localdb)\\mssqllocaldb;Database=SzulokHangjaBEContext-87d748d3-08d3-47b9-a05c-258e0abb2d44;Trusted_Connection=True;MultipleActiveResultSets=true");

        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Budapest",  Message = "Ninncs helyettesítés betegség idején", PositiveMessage=false,CommentType=Models.CommentType.MATERIAL});
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Vas",  Message = "Szuper jo az uj irodalom tanterv", PositiveMessage=true, CommentType = Models.CommentType.PERSONAL });

            modelBuilder.Entity<TeacherPostRecommendation>().HasData(new TeacherPostRecommendation() { Id = Guid.NewGuid(), Location = "Zala", Name="Maris",  Recommendation = "Több szabadságot a tanároknak"});
            modelBuilder.Entity<TeacherPostSalary>().HasData(new TeacherPostSalary() { Id = Guid.NewGuid(), Location = "Bekes", Name = "Ili",  Experience = "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", Workload= "Heti 38 óra plusz helyettesítések", Salary = 250000});
            modelBuilder.Entity<TeacherPostSalary>().HasData(new TeacherPostSalary() { Id = Guid.NewGuid(), Location = "Pjost", Name = "Zsuzs", Experience = "10 éve tanítok irodalmat és történelmet", Workload = "Heti 38 óra plusz helyettesítések", Salary = 2232323 });
        }
    }
}

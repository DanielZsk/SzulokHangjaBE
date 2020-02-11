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

        public DbSet<SzulokHangjaBE.Models.UserPosts.TeacherPostRecommendation> TeacherPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Budapest", Message= "Ninncs helyettesítés betegség idején"});
            modelBuilder.Entity<ParentPost>().HasData(new ParentPost() { Id = Guid.NewGuid(), Location = "Vas", Message = "Szuper jo az uj irodalom tanterv" });

            modelBuilder.Entity<TeacherPostRecommendation>().HasData(new TeacherPostRecommendation() { Id = Guid.NewGuid(), Location = "Zala", Recommendation = "Több szabadságot a tanároknak"});
        }
    }
}

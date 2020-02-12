using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SzulokHangjaBE.Models.UserPosts
{
    public class TeacherPostRecommendation : SuperPost
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Recommendation{ get; set; }
    }
}

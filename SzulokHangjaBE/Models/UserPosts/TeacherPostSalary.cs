using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SzulokHangjaBE.Models.UserPosts
{
    public class TeacherPostSalary:SuperPost
    {
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Workload { get; set; }
        [Required]
        public int Salary { get; set; }


    }
}

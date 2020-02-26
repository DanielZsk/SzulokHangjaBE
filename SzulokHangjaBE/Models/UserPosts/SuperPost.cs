using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SzulokHangjaBE.Models.UserPosts
{
    public abstract class SuperPost
    {
        public Guid Id { get; set; }
        [Required]
        public string Location { get; set; }
        
        public DateTime SubmissionDate { get; set; }

   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SzulokHangjaBE.Models.UserPosts
{
    public abstract class SuperPost
    {
        public SuperPost()
        {
            SubmissionDate =  DateTime.Now;
        }
        public Guid Id { get; set; }
        [Required]
        public string Location { get; set; }
        
        public DateTime SubmissionDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SzulokHangjaBE.Models.UserPosts
{
    public abstract class SuperPost
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public DateTime SubmissionDate { get; set; }

    }
}

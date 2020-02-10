using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SzulokHangjaBE.Models.UserPosts
{
    public class SuperPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Location { get; set; }
        public string ReviewTopic { get; set; }
        public bool ReviewType { get; set; }

    }
}

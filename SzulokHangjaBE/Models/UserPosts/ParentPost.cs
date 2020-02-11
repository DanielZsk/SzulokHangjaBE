using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SzulokHangjaBE.Models.UserPosts
{
    public class ParentPost : SuperPost
    {
        public string Message { get; set; }

        public string Image { get; set; }

        public Boolean PositiveMessage { get; set; }

        public CommentType CommentType { get; set; }


    }
}

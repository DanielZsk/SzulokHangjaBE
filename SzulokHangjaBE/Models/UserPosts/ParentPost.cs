using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SzulokHangjaBE.Models.UserPosts
{
    public class ParentPost : SuperPost
    {
        [Required]
        public string Message { get; set; }

        public string Image { get; set; }

        [Required]
        public Boolean PositiveMessage { get; set; }

        [Required]
        public CommentType CommentType { get; set; }


    }
}

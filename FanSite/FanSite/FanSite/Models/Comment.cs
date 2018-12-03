using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Comment
    { // list that stores the comments
       private List<Comment> comment = new List<Comment>();

        // property for comment's text
        [MinLength(2)]
        [MaxLength(25)]
        public string AStoriesComments { get; set; }

        public List<Comment> Comments { get { return comment; } }



    }
}

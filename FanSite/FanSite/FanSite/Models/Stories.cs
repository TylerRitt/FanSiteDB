using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Stories
    {
        private List<Stories> story = new List<Stories>();
        private List<Comment> comments = new List<Comment>();

        [Required] // validations
        public int ID { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Story { get; set; }

        //public string AStoriesComments { get; set; }

        public List<Stories> SavedStories { get { return story; } }
        public List<Comment> Comments { get { return comments; } }

    }
}

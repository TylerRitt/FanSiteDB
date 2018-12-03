using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class CommentRepo
    {
       private static List<Comment> comments = new List<Comment>();

       public static List<Comment> Comments { get { return comments; }}

        static CommentRepo()
        {
            AddData();
        }

        // Adds comments to the list in our comment class
        public static void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Hard coded data for comments
        static void AddData()
        {
            Comment comment;

            comment = new Comment()
            {
                AStoriesComments = "Some Random Comment"
            };

            comment.Comments.Add(comment);         
        }
    }
}

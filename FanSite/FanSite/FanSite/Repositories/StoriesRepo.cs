using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repositories
{
    public class StoriesRepo : IStoriesRepo
    {
        private AppDBContext context;

        public StoriesRepo(AppDBContext con)
        {
            context = con;
        }

        public IEnumerable<Stories> Stories { get { return context.Stories; } }

        public void AddStory(Stories stories)
        {
            context.Stories.Add(stories);
            context.SaveChanges();
        }

        public Stories GetStoriesByID(int id)
        {
            Stories stories = context.Stories.First(s => s.ID == id);
            return stories;
        }
        
        /*public int Count()
        {
            return Stories.Count();
        }*/


    }
}

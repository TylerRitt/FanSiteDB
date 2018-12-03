using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;
using FanSite.Repositories;

namespace FanSite.Repositories
{
    public class FakeStoriesRepo : IStoriesRepo
    {
        //for testing
        private List<Stories> listOfStories = new List<Stories>();

        public List<Stories> ListOfStories { get { return listOfStories; } }


        public IEnumerable<Stories> Stories => throw new NotImplementedException();

        public FakeStoriesRepo()
        {
            AddTestData();
        }


        public void AddStory(Stories stories)
        {
            ListOfStories.Add(stories);
        }

        public int Count()
        {
            return ListOfStories.Count();
        }

        public Stories GetStoriesByID(int id)
        {
            Stories stories = listOfStories.First(s => s.ID == id);
                return stories;
        }
       
        void AddTestData()
        {
            Stories firstStory = new Stories
            {
                Name = "The Life of Steve Jobs",
                Story = "Steve Jobs was CEO of Apple"

            };

            Stories secondStory = new Stories
            {
                Name = "A Story of Steve Jobs",
                Story = "Steve jobs was a frutitarian"
            };


        }

    }
}

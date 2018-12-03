using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repositories
{
    public interface IStoriesRepo
    {
        IEnumerable<Stories> Stories { get; }

        void AddStory(Stories story);

        Stories GetStoriesByID(int id);

        //int Count();



    }
}

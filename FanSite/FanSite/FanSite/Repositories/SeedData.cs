using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using FanSite.Models;

namespace FanSite.Repositories
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            // if our DB has nothing in it. Fill it with this data
            AppDBContext context = app.ApplicationServices.GetRequiredService<AppDBContext>();
            context.Database.EnsureCreated();

            if (!context.Stories.Any())
            {
                Stories firstStory = new Stories()
                {
                    Name = "The Life of Steve Jobs",
                    Story = "Steve Jobs was CEO of Apple"
                };

                context.Stories.Add(firstStory);
                context.SaveChanges();
            }

        }

    }
}

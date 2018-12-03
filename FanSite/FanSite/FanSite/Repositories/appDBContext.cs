using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FanSite.Models;


namespace FanSite.Repositories
{
    public class AppDBContext : DbContext
    {

        // all dbsets
        public AppDBContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<Stories> Stories { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}

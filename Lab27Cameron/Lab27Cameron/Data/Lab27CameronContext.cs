using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab27Cameron.Models;

namespace Lab27Cameron.Models
{
    public class Lab27CameronContext : DbContext
    {
        public Lab27CameronContext (DbContextOptions<Lab27CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab27Cameron.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Lab27Cameron.Models.Song> Song { get; set; }
    }
}

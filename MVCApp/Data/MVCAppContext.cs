using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApp.Models;

namespace MVCApp.Data
{
    public class MVCAppContext : DbContext
    {
        public MVCAppContext (DbContextOptions<MVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCApp.Models.Movie> Movie { get; set; } = default!;
    }
}

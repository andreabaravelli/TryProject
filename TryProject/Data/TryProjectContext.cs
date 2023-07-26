using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TryProject.Models;

namespace TryProject.Data
{
    public class TryProjectContext : DbContext
    {
        public TryProjectContext (DbContextOptions<TryProjectContext> options)
            : base(options)
        {
        }

        public DbSet<TryProject.Models.Job> Job { get; set; } = default!;
    }
}

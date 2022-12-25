using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FastJob.Models;

namespace FastJob.Data
{
    public class FastJobContext : DbContext
    {
        public FastJobContext (DbContextOptions<FastJobContext> options)
            : base(options)
        {
        }

        public DbSet<FastJob.Models.Tasks> Tasks { get; set; } = default!;
    }
}

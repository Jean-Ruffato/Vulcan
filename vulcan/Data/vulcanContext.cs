using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace vulcan.Models
{
    public class vulcanContext : DbContext
    {
        public vulcanContext (DbContextOptions<vulcanContext> options)
            : base(options)
        {
        }

        public DbSet<vulcan.Models.Vulnerabilities> Vulnerabilities { get; set; }
    }
}
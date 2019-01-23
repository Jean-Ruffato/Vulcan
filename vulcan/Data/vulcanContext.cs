using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace vulcan.Models
{
    public class VulcanContext : DbContext
    {
        public VulcanContext (DbContextOptions<VulcanContext> options)
            : base(options)
        {
        }

        public DbSet<Vulnerabilities> Vulnerabilities { get; set; }
        public DbSet<Scan> Scan { get; set; }
    }
}
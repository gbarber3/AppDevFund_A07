using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using NorthwindSystem.Entities;

namespace NorthwindSystem.DAL
{
    internal class NorthwindContext:DbContext
    {
        public NorthwindContext() : base("NWDB")
        {

        }

        public DbSet<Products> Products { get; set; }

        public DbSet<Region> Region { get; set; }
    }
}

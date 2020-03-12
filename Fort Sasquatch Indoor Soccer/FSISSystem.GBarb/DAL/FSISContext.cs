﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using FSISSystem.GBarb.Entities;

namespace FSISSystem.GBarb.DAL
{
    internal class FSISContext:DbContext
    {
        public FSISContext() : base("FSIS_db")
        {

        }

        public DbSet<Guardian> Guardian { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }
    }
}

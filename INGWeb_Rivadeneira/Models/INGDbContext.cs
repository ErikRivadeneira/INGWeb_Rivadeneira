using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INGWeb_Rivadeneira.Models
{
    public class INGDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Scores> Scores { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Options> Options { get; set; }
    }
}
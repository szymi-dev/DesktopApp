using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected DataContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
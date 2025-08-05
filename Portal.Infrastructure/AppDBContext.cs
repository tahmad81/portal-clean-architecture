using Portal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Portal.Infrastructure
{
    public class AppDBContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Blog> Blogs => Set<Blog>();
        public DbSet<User> Users => Set<User>();    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent configurations if needed
        }

    }

}

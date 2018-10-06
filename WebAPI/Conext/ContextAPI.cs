using System;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Context
{
    public class ContextAPI : DbContext
    {
        public ContextAPI(DbContextOptions<ContextAPI> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> Person { get; set; }
    }
}

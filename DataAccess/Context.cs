using DataAccess.Configurations;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Text> Texts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=DESKTOP-DB25QGC\SQLEXPRESS;Initial Catalog=OrionInnovationTest;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var text = new List<Text>
            {
                new Text
                {
                    Id = 1,
                    AllText = "Test test test test test "
                }
            };
            modelBuilder.Entity<Text>().HasData(text);
            modelBuilder.ApplyConfiguration(new TextConfiguration());
        }
    }
}

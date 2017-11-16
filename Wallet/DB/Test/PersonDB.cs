using System;
using Microsoft.EntityFrameworkCore;

namespace DB.Test
{
    public class PersonDB : DbContext
    {   
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=35.196.72.6;userid=root;password=attack91;database=Wallet;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Person>(pX => 
            {
                pX.HasKey(pEntity => new { pEntity.Id });
                pX.Property(pEntity => pEntity.Id).IsRequired().ValueGeneratedOnAdd();
                pX.Property(pEntity => pEntity.Name).IsRequired().HasMaxLength(100);
                pX.Property(pEntity => pEntity.LastName).HasMaxLength(100);
                pX.Property(pEntity => pEntity.Salary).IsRequired();
                pX.Property(pEntity => pEntity.Active).IsRequired().HasDefaultValue(true);
                pX.Property(pEntity => pEntity.DateOfCreation);
                pX.Property(pEntity => pEntity.DateOfUpdate);
                pX.Property(pEntity => pEntity.Age);
            });
        }


    }
}

using System;
using Microsoft.EntityFrameworkCore;

namespace DB.Test
{
    public class PersonDB : DbContext
    {   
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }



    }
}

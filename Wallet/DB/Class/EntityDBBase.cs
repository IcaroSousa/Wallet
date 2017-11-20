using System;
using Microsoft.EntityFrameworkCore;

namespace DB.Class
{
    public class EntityDBBase : DbContext
    {        
        protected string ConnectinString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectinString);
        }

    }
}

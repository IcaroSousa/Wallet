using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Test
{    
    public class Person
    {                
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        public bool Active { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfUpdate { get; set; }

        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(int pId, string pName, string pLastName, int pAge)
        {
            Id = pId;
            Name = pName;
            LastName = pLastName;
            Age = pAge;
        }


    }
}

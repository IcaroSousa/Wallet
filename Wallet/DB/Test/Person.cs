using System;
using System.ComponentModel.DataAnnotations;
using DB.Class;

namespace DB.Test
{    
    public class Person : EntityBase
    {                        
        public string Name { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        public bool Active { get; set; }

        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(string pName, string pLastName, int pAge)
        {            
            Name = pName;
            LastName = pLastName;
            Age = pAge;
        }


    }
}

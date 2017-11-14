using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Test
{    
    public class Person
    {        
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

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

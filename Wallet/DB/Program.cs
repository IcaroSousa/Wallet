using System;
using System.Collections.Generic;
using System.Linq;
using DB.Test;

namespace DB
{    
    static class Program
    {
        public static void Main()
        {
            PersonRepository lRepo = new PersonRepository();

            List<Person> lPersons = lRepo.FindBy(pX => pX.Name == "Doe").ToList();
            lPersons.ForEach((Person pPerson) => 
            {
                Console.WriteLine($"Nome :{pPerson.Name} Sobrenome: {pPerson.LastName}");
            });

            while(lPersons.Any())
            {
                lRepo.Delete(lPersons.Take(1000).ToArray());
                lRepo.Save();
                lPersons = lRepo.FindBy(pX => pX.Name == "Doe").ToList();
            }


            int.TryParse(Console.ReadLine(), out int lKey);

            while(lKey == 0)
            {
                Console.WriteLine("---------------");
                lPersons = lRepo.GetAll().ToList();

                lPersons.ForEach((Person pPerson) => 
                { 
                    Console.WriteLine($"Nome :{pPerson.Name} Sobrenome: {pPerson.LastName}"); 
                }); 

                int.TryParse(Console.ReadLine(), out lKey);
            }

        }

    }
}

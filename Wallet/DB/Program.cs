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

            List<Person> lPersons = lRepo.FindBy(pX => pX.Name == "Icaro").ToList();
            lPersons.ForEach((Person pPerson) => { Console.WriteLine($"Nome :{pPerson.Name} Sobrenome: {pPerson.LastName}");});

            lPersons.ForEach((Person lperson) => 
            { 
                lRepo.Delete(lperson); 
                lRepo.Save(); 
            });


            int.TryParse(Console.ReadLine(), out int lKey);

            while(lKey == 0)
            {
                Console.WriteLine("---------------");
                lPersons = lRepo.GetAll().ToList();
                lPersons.ForEach((Person pPerson) => { Console.WriteLine($"Nome :{pPerson.Name} Sobrenome: {pPerson.LastName}"); }); 

                int.TryParse(Console.ReadLine(), out lKey);
            }

        }

    }
}

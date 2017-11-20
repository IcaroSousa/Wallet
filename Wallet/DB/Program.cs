using System;
using System.Collections.Generic;
using System.Linq;
using DB.Test;

namespace DB
{    
    static class Program
    {
        static void Count(int[][] pArray)
        {
            int lSum = 0;
            for (int lIndex = 0; lIndex < 4; lIndex++)
            {
                for (int lIndex2 = 0; lIndex2 < 4; lIndex2++)
                {
                    int lInternal = 0;

                    lInternal += pArray[lIndex][lIndex2];
                    lInternal += pArray[lIndex][lIndex2 + 1];
                    lInternal += pArray[lIndex][lIndex2 + 2];
                    lInternal += pArray[lIndex + 1][lIndex2 + 1];
                    lInternal += pArray[lIndex + 2][lIndex2];
                    lInternal += pArray[lIndex + 2][lIndex2 + 1];
                    lInternal += pArray[lIndex + 2][lIndex2 + 2];

                    if ((lInternal > lSum) || ((lIndex == 0) && (lIndex2 == 0)))
                    {
                        lSum = lInternal;
                    }
                }
            }

            Console.WriteLine(lSum);
        }

        public static void Main()
        {
            PersonRepository lRepo = new PersonRepository();
            /*
            List<Person> lPeople = new List<Person>()
            {
                new Person(6, "Icaro", "Sousa", 25),
                new Person(7, "Sousa", "", 22),
                new Person(8, "Laiane", "Flores", 17),
                new Person(9, "Mingau", "Flores", 12),
                new Person(10, "Geziel", "Bastos", 48),
            };

            lRepo.Add(lPeople);
            lRepo.Save();
            */

            List<Person> lPersons = lRepo.GetAll().ToList();
            lPersons.ForEach((Person pPerson) => { Console.WriteLine($"Nome :{pPerson.Name} Sobrenome: {pPerson.LastName}");});

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

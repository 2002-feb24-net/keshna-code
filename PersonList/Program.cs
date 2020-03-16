using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
                var person = new Person();

            List<string> Person = new List<string> { "andy", "mandy", "sandy", "tom", "jerry", "tom" };
            //Console.WriteLine("Hello World!");
            if (FindDuplicates(Person))
            {
                Console.WriteLine("Yes found a duplicate");
            };


            foreach (var item in Person)
            {
                Console.WriteLine(item);
            }
            
        }

        public static bool FindDuplicates(List<string> array)
        {
            bool result= false;
            var hashset = new HashSet<string>();
            foreach (var name in array)
            {
                if (!hashset.Add(name))
                {
                    Console.WriteLine("List contains duplicate values.");
                    result = true;
                    
                }
                else
                {
                    result =false;
                }
               
            }
            return result;
        }


    }
}

//
// The main difference between bubble sort and insertion sort is that 
// bubble sort performs sorting by checking the neighboring data elements and
//  swapping them if they are in wrong order while insertion
//   sort performs sorting by transferring one element to a partially 
//   sorted array at a time. 
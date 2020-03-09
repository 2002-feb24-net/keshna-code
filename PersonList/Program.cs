using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> Persons = new List<string>{"andy","mandy","sandy","tom","jerry"};
            //Console.WriteLine("Hello World!");
           if (FindDuplicates(Persons)) { 
               Console.WriteLine($"Yes we find duplicate"); };

          
            foreach (var item in Persons)
            {
             Console.WriteLine(item);   
            }
        }

        public static bool FindDuplicates(List<string> array)
    {
        var dict = new Dictionary<string, int>();
        foreach (var value in array)
        {
            if (dict.ContainsKey(value))
                dict[value]++;
            else
                dict[value] = 1;
        }
        foreach (var pair in dict)
        {
            if (pair.Value > 1)
                return true;
            else
                return false;
        }
        return false;
    }


 }
}

//
// The main difference between bubble sort and insertion sort is that 
// bubble sort performs sorting by checking the neighboring data elements and
//  swapping them if they are in wrong order while insertion
//   sort performs sorting by transferring one element to a partially 
//   sorted array at a time. 
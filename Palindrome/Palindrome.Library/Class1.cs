using System;

namespace Palindrome.Library
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var Strategy = new PalStratergy();
            string input = "nurses run";
            bool results = Strategy.IsPalindrome(input);
            if (results)
            {
                Console.WriteLine("pal");
            }
            else
            {
                Console.WriteLine("Not a pal");
            }
        }
    }
}
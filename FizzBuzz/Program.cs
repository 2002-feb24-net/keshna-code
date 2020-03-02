using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           int N = 1000; 
           int a=0;
           int b=0;
           int c= 0; 
         
        // iterate from 0 to N 
        for (int num = 0; num <= N; num++) 
        {     
           
            // condition  
            if (num % 3 == 0 && num % 5 != 0) 
              { 
                 a= a+1 ;
                   Console.WriteLine("Fizz"); //267
              }
            else if(num % 5 == 0 && num % 3 != 0) 
              { 
                  b=b+1;
                   Console.WriteLine("Buzz"); //134
              }
            else if(num % 5 == 0 && num % 3 == 0) 
              { 
                  c=c+1;
                   Console.WriteLine("FizzBuzz"); //67
              }
              else
              {
                  Console.WriteLine(num);
              }
      
        }
                Console.WriteLine("Fizz :"+ a + " Buzz : "+ b + " FizzBuzz : " +c); // 267 134 67
        }
    }
}

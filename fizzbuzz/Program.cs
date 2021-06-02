using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("podaj liczbe badz wpisz 'exit' aby wyjsc");
                var number = GetInput();
                if (number%3==0 && number%5==0)
                {
                    Console.WriteLine("FIZZBUZZ");
                    
                    continue;
                    
                }               
                if (number%3 == 0)
                {
                    Console.WriteLine("Fizz");
                    
                    continue;
                }
                if ( number%5==0 )
                {
                    Console.WriteLine("Buzz");
                    
                    continue;
                }
                else
                {
                    Console.WriteLine(number);
                    
                }
                
            }
        }

        private static int GetInput()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper()=="EXIT")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(val,out int number))
                {
                    Console.WriteLine("złe dane");
                }
                return number;
            }
        }
    }
}

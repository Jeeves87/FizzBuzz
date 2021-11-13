using System;


namespace FizzBuzz
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("FizzBuzz seeks to find out if any number from a series of numbers is divisible by 3, 5 or both.");
            Console.WriteLine("Please enter a number you would like to start from.");
            string Input1 = Console.ReadLine();
            Console.WriteLine("Thank you! Now enter a size for the array (ex: 100)");
            string Input2 = Console.ReadLine();
            GetArray GetArray = new(Input1, Input2);
            int[] UserArray = GetArray.userArray;
            UserArray = GetArray.MakeArray();
            foreach (int i in UserArray)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine($"{i}- Fizz Buzz!");
                    continue;
                }


                if ((i % 5) == 0)
                {
                    Console.WriteLine($"{i}- Buzz!");
                    continue;
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine($"{i}- Fizz!");
                    continue;
                }

                             
            }
                
        }
    }
}

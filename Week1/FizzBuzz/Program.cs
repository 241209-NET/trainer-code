using System.Security.Cryptography;

namespace FizzBuzz;

/*
Given a number  n by the user.
Count starting from 1 to n
Each time we get to a number that is divisible by 3, replace with fizz 
Each time we get to a number that is divisible by 5, replace with buzz 
Each time we get to a number that is divisible by 3 and 5 eg. 15, replace with fizzbuzz 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number.");
        string input = Console.ReadLine()!;

        if(String.IsNullOrWhiteSpace(input)){
            input = "1";
        }

        int number = Convert.ToInt32(input);

        for(int i = 1; i <= number; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else Console.WriteLine(i);
        }

    }
}

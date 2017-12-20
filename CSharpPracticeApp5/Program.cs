using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeApp5
{
    class Program
    {
        static void Main(string[] args)
        {//Write a program to count how many numbers between 1
         //and 100 are divisible by 3 with no remainder. Display the count on the console.
            var sum = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(); //blank 

            //Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.

            string userInput;
            int temp;
            int total=0;
            do
            {
                Console.WriteLine("Please enter a whole number: ");
                userInput = Console.ReadLine();
                bool indicator = int.TryParse(userInput, out temp); //only if it registers as a number when parsed (bool value of true), add it to the total
                Console.WriteLine(indicator);
                if (indicator)
                {
                    total += temp;
                }

                Console.WriteLine("Your total is now {0}", total);

            } while (userInput != "ok");

            if (userInput.ToLower() == "ok")
            {
                Console.WriteLine("Goodbye.");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable_FindMyPast_
//Program to multiply prime numbers up to a given number, and represent these in a table
//Assignment for FindMyPast
//Cameron O'Brien
//cameronobrien12@hotmail.co.uk

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables that we used to save whether a number is prime or not 
            bool prime = false;
            bool prime2 = false;


            //Get user input for size of table (table is of size "size+1")
            Console.WriteLine("Choose the size of your table");
            Console.WriteLine("Enter choice: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice is: " + size);
            //Start of table output
            Console.Write("*   | ");

            //Finds the Prime numbers used for the X-Axis
            for (int i = 1; i < size + 2; i++)
            {
                //Uses my isprime function to check each number
                prime = IsPrime(i);
                if (prime == true)
                {
                    //if statement needed for formatting of table with different digit length numbers
                    if (i < 10)
                        Console.Write(i + "   | ");
                    else if (i > 9 && i < 100)
                        Console.Write(i + "  | ");
                    else if (i > 99 && i < 1000)
                        Console.Write(i + " | ");
                    else
                        Console.Write(i + "| ");
                }
            }

        }

        //method used to check if a number is prime
        static bool IsPrime(int i)
        {
            //1 is not prime
            if (i == 1)
            {
                return false;
            }
            //check all nubmers below current
            for (int j = 2; j <= i; j++)
            {
                // but dont check divide by itself
                if (j != i)
                {
                    //if divides by any other number
                    if (i % j == 0)
                    {
                        //not prime
                        return false;
                    }
                }
            }
            //else it is prime
            return true;
        }
    }
}

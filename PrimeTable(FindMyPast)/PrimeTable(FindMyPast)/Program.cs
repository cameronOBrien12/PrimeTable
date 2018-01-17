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
            
            //formatting table
            Console.WriteLine("");
            Console.WriteLine("----+---------");

            //Finds the Prime numbers used for the Y-Axis and then used in loop to fill table
            for (int i = 1; i < size + 2; i++)
            {
                //check if number is prime
                prime = IsPrime(i);
                if (prime == true)
                {
                    //need if for formatting again
                    if (i < 10)
                        Console.Write(i + "   | ");
                    else if (i > 9 && i < 100)
                        Console.Write(i + "  | ");
                    else if (i > 99 && i < 1000)
                        Console.Write(i + " | ");
                    else
                        Console.Write(i + "| ");


                    //fills in table , times row by column
                    for (int j = 1; j < size + 2; j++)
                    {
                        //check if both x and y axis are prime
                        prime = IsPrime(i);
                        prime2 = IsPrime(j);
                        //if they both are then we will calculate their answer
                        if (prime == true & prime2 == true)
                        {
                            int answer = j * i;
                            //if for formatting of answers in table
                            if (answer < 10)
                                Console.Write(answer + "   | ");
                            else if (answer > 9 && answer < 100)
                                Console.Write(answer + "  | ");
                            else if (answer > 99 && answer < 1000)
                                Console.Write(answer + " | ");
                            else
                                Console.Write(answer + "| ");

                        }
                    }
                    Console.Write("\n");
                }
            }
            //statement to exit program
            Console.WriteLine("");
            Console.Write("Press enter to exit");
            string exit = Console.ReadLine();
        }

        //Method which finds if a number is prime or not, takes an int, returns a boolean
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

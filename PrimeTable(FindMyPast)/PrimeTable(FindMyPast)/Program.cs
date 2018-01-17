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
            Console.WriteLine("Paused - Press enter to see test results for isPrime function");
            string exit = Console.ReadLine();
            Console.WriteLine("TEST RESULTS:");
            PrimeTesting();
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("GENERATOR OF PRIME NUMBERS");
            Console.WriteLine("This is set to print the first million primes, you may want to end it early :)");
            Console.WriteLine("Paused - Press enter to continue to generator ( CTRL-C to escape early )");
            exit = Console.ReadLine();
            PrimeNumberGenerator();

            Console.Write("Press enter to exit");
             exit = Console.ReadLine();
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

        //some testing for the isPrime method
        static void PrimeTesting()
        {
           Console.WriteLine("Is 3 prime? " + IsPrime(3) );
           Console.WriteLine("Is 7 prime? " + IsPrime(7) );
           Console.WriteLine("Is 1,000,000 prime? " + IsPrime(1000000));
           Console.WriteLine("Next one takes a few seconds...");
           Console.WriteLine("Is 533,000,389 prime? " + IsPrime(533000389));

        }

        //I realised I didn't really use a prime number generator in my program, 
        //so I am adding this method to show that I know how to create one 
        static void PrimeNumberGenerator()
        {
            //counts which prime number we are on
            int PrimeCount = 0;
            //starting at first prime number
            int number = 2;
            //loop until at prime number
            do
            {
                //if number is prime
                if (IsPrime(number))
                {
                    //add to prime count
                    PrimeCount++;
                    Console.WriteLine(number);
                }

                //check next number
                number++;

                //CHANGE THIS VARIABLE TO GET ALL PRIMES UP TO HOW MANY YOU NEED, e.g. first million
            } while (PrimeCount != 1000000);

            //return to previous number - 1000000st prime number
            number--;
            //write to console
            Console.WriteLine("The 1000000 Prime Number is: {0}", number);
        }
    }
}

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
            //Get user input for size of table (table is of size "size+1")
            Console.WriteLine("Choose the size of your table");
            Console.WriteLine("Enter choice: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your choice is: " + size);
            //Start of table output
            Console.Write("*   | ");
        }
    }
}

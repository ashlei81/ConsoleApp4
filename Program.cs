using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<DogFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new DogFood();

                Console.WriteLine("Enter the value for ");
                Dryorganic = Console.ReadLine();
                Dogleash = Console.ReadLine();
                quanity = Console.ReadLine();
                price = Console.ReadLine();
                



                recordList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()

        }
    }

using System;
using System.Linq;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message? ");
            string input = Console.ReadLine();
            string inputUpper = input.ToUpper();
            int Checksum = inputUpper.ToArray().Select(x => (int)x).Sum();
            Console.WriteLine("Checksum is: " + Checksum);



            Console.WriteLine("Your encoded message is: ");
            foreach (char c in inputUpper)

                
                Console.Write(((int)c - 64) + "-");

            
        }
        }

        











    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Milline number on kõige suurem?

            /*
            int userNumber1;
            int userNumber2;
            int userNumber3;
            Console.WriteLine("Sisesta palun üks number 1-10ni.");
            userNumber1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta palun teine number 1-10ni.");
            userNumber2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta palun kolmas number 1-10ni.");
            userNumber3 = Int32.Parse(Console.ReadLine());



            if (userNumber1 > userNumber2)
            {
                if (userNumber1 > userNumber3)
                {
                    Console.WriteLine($"{userNumber1} on kõige suurem");
                }
                else
                {
                    Console.WriteLine($"{userNumber3} on kõige suurem");
                }

            }
            else
            {
                if (userNumber2 > userNumber3)
                {
                    Console.WriteLine($"{userNumber2} on kõige suurem");

                }
                else
                {
                    Console.WriteLine($"{userNumber3} on kõige suurem");
                }
            }

            Console.ReadLine();
                */
            
            


            //Random number generator
                        
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);
            Console.WriteLine(randomNumber);

            Console.ReadLine();
        
            

        }
    }
}

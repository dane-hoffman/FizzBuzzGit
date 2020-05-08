using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProj
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int count = 1; count < 101; count++)
            {

                Console.WriteLine(count);

                if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                
                if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }

                else if (count % 3 == 0 || count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }



                //else 
                //{
                //    Console.WriteLine(count);

                //}



                




            }

            Console.ReadLine();


        }


    }

}


    

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


            for (double count = 0; count < 101; count++)
            {

                Console.WriteLine(count);

                if (count % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }


            }




            Console.ReadLine();


        }


    }

}
    

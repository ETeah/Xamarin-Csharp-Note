using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int f = 0; f < 10; f++)
            {

                if(f == 3)
                {
                    Console.WriteLine("You have {0}", f);
                    break;
                }

                Console.WriteLine(f);
              
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note2
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a value:");
            string rReader = Console.ReadLine();


            string message = "";
            if (rReader == "2")
            {
                message = "You ok";
                
              
            }
            else if (rReader == "3")
            {
                message = "what are you doing?";
              
            }
       //The last decision -if all else falses
            else
            {
                Console.Write("Can't get you!");
               
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }

    }
}

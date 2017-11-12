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



            /*
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


            */
            /*
            //Below is a decision method that uses one 
            //statement to check if the input is true or false

       Console.WriteLine("Put in a number:");
       string userInput = Console.ReadLine();


            //here is the if else statement all in one...
            string result = (userInput == "2") ? "car" : "can't have anything";

       
            Console.WriteLine(result);
          
            Console.ReadLine(); 

*/

            //Below is another way to replace a statement's function representer/variable name
            //by using numerical indexes 
            //that keeps a value, and shorted the code 

            Console.WriteLine("Put in a number:");
            string userInput = Console.ReadLine();


            //here is the if else statement all in one...
            string result = (userInput == "2") ? "car" : "can't have anything";

            //here, the {0} replaces userInput, the {1} holds result variable

            Console.WriteLine("You enter: {0}, therefore you {1}.", userInput, result);
            Console.ReadLine();


            //Operions are syntaxs 
            //operators are + = and other calculation
            //sysmbols what makes the computable logic/expression  of a statement







        }

    }
}

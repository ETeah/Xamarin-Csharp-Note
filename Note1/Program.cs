using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Note1             {
class Program
                            {

        //Void Start
        static void Main(string[] args)
        {


            SubClass.Start();
           
           
            Console.ReadLine();

        }


        class SubClass
        {

            public static void Start()
            {
                //Question
                 Console.Write("Whats your name?");
                Console.ReadLine();

                //Input
                System.Console.Write("Write your first name:");
                //Result 
                //Storage
                string last_Name = Console.ReadLine();

                Console.WriteLine("Hello" + " " + last_Name.ToString());
                Console.ReadLine();


            }
        }


    }
}

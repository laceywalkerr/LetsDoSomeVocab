using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoSomeVocab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Variable: Containers of data*/

            /*to define a variable: 
            1. write the type (int, bool, string, char, ect)
            2. the name (taco)
            3. (optional) innitialize it with a value (lets say that the value the type is equal to is 7)
            This is a variable:   (*/

            int taco = 7;

            /*This is a string concatination using a variable, which will display "Hello World! 7" */

            Console.WriteLine("Hello World!" + taco);

            Console.ReadKey();
        }

        /* this is a function
         * you first define a function by writing the return type
         if you want to return nothing, you can use void
        then you write the name of the function
        then add parameters within the parentheses if there are any */

        /* the top function returns nothing and takes no parameters*/

        /* the second function returns a boolean and takes an int parameter*/



        void TestFunction(/*You would add parameters here*/)
        {
            bool SecondTestFunction(int taco)
            {
                return int < 100;
            }
        }

    }
}

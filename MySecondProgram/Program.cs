using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a comment lmao
            /*
             * this
             * is
             * a
             * multi
             * line
             * comment
             */

            Console.Write("Hey");
            Console.WriteLine("I like pizza");
            Console.WriteLine("It's really good!");

            Console.WriteLine("h\nMe");




            int x; // decleration
            x = 123; // initialisation

            int y = 321; // decleration and initialisation

            int z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            int age = 21; //whole integer
            double height = 300.5; // double stores a decimal number
            bool alive = true; // true or false
            char symbol = '@'; // only assign a single character and in single quotes
            String name = "zay"; // assign several characters and also String has to be capital

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Hello " + name);

            String userName = symbol + name;

            Console.WriteLine("Your username is " + userName);



            Console.Beep();
            Console.ReadKey();
        }
    }
}

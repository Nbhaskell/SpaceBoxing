using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //     It should ask you what your earth weight is, and to enter a number for the planet you want to fight on.It should then compute your weight on the destination 
            //     planet based on the table below:

            //#    Planet    Relative gravity
            //1    Venus     0.78
            //2    Mars       0.39
            //3    Jupiter    2.65
            //4    Saturn    1.17
            //5    Uranus   1.05
            //6    Neptune 1.23
  
            Console.WriteLine("Enter your weight in pounds: ");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Select the planet where you will be fighting: ");
            Console.WriteLine("[1] Venus");
            Console.WriteLine("[2] Mars");
            Console.WriteLine("[3] Jupiter");
            Console.WriteLine("[4] Saturn");
            Console.WriteLine("[5] Uranus");
            Console.WriteLine("[6] Neptune");
            var userinput = Console.ReadLine();

            double venus = weight * .78;
            double mars = weight * .38;
            double jupiter = weight * 2.65;
            double saturn = weight * 1.17;
            double uranus = weight * 1.05;
            double neptune = weight * 1.23;

            if (userinput == "1")
            {
                Console.WriteLine("Your weight on venus is: {0} lbs.", venus);
            }
            if (userinput == "2")
            {
                Console.WriteLine("Your weight on mars is: {0} lbs.", mars);
            }
            if (userinput == "3")
            {
                Console.WriteLine("Your weight on jupiter is: {0} lbs.", jupiter);
            }
            if (userinput == "4")
            {
                Console.WriteLine("Your weight on saturn is: {0} lbs.", saturn);
            }
            if (userinput == "5")
            {
                Console.WriteLine("Your weight on uranus is: {0} lbs.", uranus);
            }
            if (userinput == "6")
            {
                Console.WriteLine("Your weight on neptune is: {0} lbs.", neptune);
            }
            Console.ReadLine();
        }
    }
}

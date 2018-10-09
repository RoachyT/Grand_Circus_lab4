using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, square, cube;
            string getNumber,rerun;
            Boolean flag = true;

            Console.WriteLine("Learn your Squares and Cubes!");

            do
            {
                Console.WriteLine("Enter an integer: ");
                getNumber = Console.ReadLine();
                number = int.Parse(getNumber);
                Console.WriteLine("{0, -10:0}{1, -10:0}{2, -10:0}", "Number", "Square", "Cube");
                Console.WriteLine("{0, -10:0}{1, -10:0}{2, -10:0}", "====", "====", "====");
                for (int x = 1; x <= number; x++)
                {
          
                    square = x * x;
                    cube = x * x * x;

                    
                    Console.WriteLine("{0, -10:0}{1, -10:0}{2, -10:0}", x, square, cube);
                                        
                }

                Console.Write("Do you wish to continue? Y/N ");
                rerun = Console.ReadLine();

                if (rerun.ToLower() == "n")
                {
                    flag = false;
                    Console.WriteLine("Goodbye");
                }

            }
            while (flag);

        }
    }
}

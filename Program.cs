using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summerwheels
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program where you enter the pattern depth on summer wheels
            Console.Write("Here you enter the pattern depth on your summer wheels in mm ( exemple 1,2): ");
            double patternDepth = double.Parse(Console.ReadLine());
            if (patternDepth < 1.6)
            {
                Console.WriteLine("Illegal wheels!");
            }
            else
            {
                Console.WriteLine("Legal wheels!");
            }
            Console.ReadLine();


            /*If the pattern depth is below 1.6mm,
            the text "Illegal wheels!" printed, otherwise the text "Legal wheels!" printed.*/
        }
    }
}

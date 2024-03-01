using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OsintsevKP.Sprint3.Review.V27.Lib;

namespace Tyuiu.OsintsevKP.Sprint3.Review.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Стapт wara = " + startValue);
            Console.WriteLine("Koнey wara = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РEЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine($"| {startValue,5:d}    |  {valueArray[i],6:f2}  | ");
                startValue++;

            } 
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
            
        }
    }
}

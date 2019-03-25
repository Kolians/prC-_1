using System.Globalization;
using System;

namespace project
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Математические операции");
            string param;
            param = Console.ReadLine();
            double z = 1.842840;
            double x = Convert.ToDouble(param);
            double y = 3.7 * Math.Sqrt(5-x) * Math.Cos(3.5-x)-z;
            Console.WriteLine("Результат =" + y);
            Console.Read(); 
        }
    }
}

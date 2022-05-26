using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_Payment
{
    public class Monthlypayment
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter the principle");
            double P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number of Years");
            double Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            //double x = Math.Pow((1 + r), -n);
            //Console.WriteLine(x);

            double Payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly payment that has to be paid : " + Payment);
        }
    }
}

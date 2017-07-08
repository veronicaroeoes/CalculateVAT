using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn7._3MomsTvåInparametrar
{
    class Program
    {
        static void Main(string[] args)
        {
            float nr = 0;
            float VAT = 0;
            bool loop = true;
            bool secondLoop = true;

            Console.Write("Enter amount: ");
            while (loop)
            {
                try
                {
                    nr = float.Parse(Console.ReadLine());
                    loop = false;
                }
                catch
                {
                    Console.WriteLine("You must enter numbers.");
                }
            }

            Console.Write("Enter VAT rate (if you want to calculate the sum exluding VAT rate, write - in front of the VAT rate): ");
            while (secondLoop)
            {
                try
                {
                    VAT = float.Parse(Console.ReadLine());
                    secondLoop = false;
                }
                catch
                {
                    Console.WriteLine("You must enter numbers.");
                }
            }
            if (VAT > 0)
            {
                Console.WriteLine($"{nr:c} including {VAT} % VAT is: {CalculateVAT(nr, VAT):c}");
            }
            else
            {
                Console.WriteLine($"{nr:c} excluding {MakeVATPositive(VAT)} % VAT is: {CalculateVAT(nr, VAT):c}");
            }

        }

        private static float MakeVATPositive(float VAT)
        {
            float positiveVAT = Math.Abs(VAT);
            return positiveVAT; 
        }

        private static float CalculateVAT(float number, float VAT)
        {
            float sum = number + (number * VAT / 100);
            return sum;
        }
    }
}

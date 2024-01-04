using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class BonAppetit
    {
        internal static void Init()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }

        private static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int total = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                total += bill[i];
            }

            total /= 2;

            if (total == b) Console.WriteLine("Bon Appetit");
            else Console.WriteLine(Math.Abs(total - b));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class CountApplesAndOranges
    {
        internal static void Init()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesInsideHouse = 0;
            int orangesInsideHouse = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                {
                    applesInsideHouse++;
                }
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                if (b + oranges[i] >= s && b + oranges[i] <= t)
                {
                    orangesInsideHouse++;
                }
            }

            Console.WriteLine(applesInsideHouse);
            Console.WriteLine(orangesInsideHouse);
        }
    }
}

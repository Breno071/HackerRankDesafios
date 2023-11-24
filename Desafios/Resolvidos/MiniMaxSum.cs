using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class MiniMaxSum
    {
        internal static void Init()
        {
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            miniMaxSum(arr);
        }

        private static void miniMaxSum(List<long> arr)

        {
            //var newList = new List<long>();

            long min = arr.Min();
            long max = arr.Max();

            var MinList = new List<long>();
            var MaxList = new List<long>();

            MinList.AddRange(arr);
            MaxList.AddRange(arr);

            MinList.Remove(max);
            MaxList.Remove(min);

            Console.WriteLine(MinList.Sum() + " " + MaxList.Sum());
        }
    }
}

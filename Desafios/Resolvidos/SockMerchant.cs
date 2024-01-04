using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class SockMerchant
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            sockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static void sockMerchant(int n, List<int> ar)
        {
            int countPairs = 0;

            while (ar.Count > 0)
            {
                var results = ar.FindAll(x => x == ar[0]);
                var temp = ar[0];

                if(results.Count >= 2)
                {
                    countPairs += Math.DivRem(results.Count, 2, out int result);
                }
                ar.RemoveAll(x => x == temp);
            }

            Console.WriteLine(countPairs);
        }
    }
}

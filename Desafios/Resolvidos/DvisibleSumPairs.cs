using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    internal class DvisibleSumPairs
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = divisibleSumPairs(n, k, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int qtdPairs = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = 0; j < ar.Count; j++)
                {
                    if(i != j)
                    {
                        if ((ar[i] + ar[j]) % k == 0)
                        {
                            qtdPairs++;
                        }
                    }
                }
            }

            return qtdPairs / 2;
        }
    }
}

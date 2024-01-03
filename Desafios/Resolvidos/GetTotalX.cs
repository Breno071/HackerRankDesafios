using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class GetTotalX
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            getTotalX(arr, brr);

            //textWriter.WriteLine(total);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;
            for (int c = 1; c <= 100; c++)
            {
                bool ok = true;
                for (int i = 0; i < a.Count; i++)
                {
                    if (c % a[i] != 0) ok = false;
                }

                for (int j = 0; j < b.Count; j++)
                {
                    if (b[j] % c != 0) ok = false;
                } 

                if(ok) count++;
            }
            return count;
        }
    }
}

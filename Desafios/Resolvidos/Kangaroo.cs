using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class Kangaroo
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            kangaroo(x1, v1, x2, v2);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var kangaroo1 = x1;
            var kangaroo2 = x2;

            for (int i = 1; i <= 10000; i++)
            {
                kangaroo1 += v1;
                kangaroo2 += v2;
                if (kangaroo1 == kangaroo2)
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}

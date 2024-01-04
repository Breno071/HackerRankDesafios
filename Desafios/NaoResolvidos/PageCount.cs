using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class PageCount
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            pageCount(n, p);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int pageCount(int n, int p)
        {
            int result;

            if (n % 2 == 0)
            {
                n++;
            }
            int front = p / 2;
            int back = (n - p) / 2;
            result = Math.Min(front, back);
            return result;
        }
    }
}

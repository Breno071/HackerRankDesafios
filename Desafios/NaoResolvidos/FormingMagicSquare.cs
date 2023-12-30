using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class FormingMagicSquare
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            int result = formingMagicSquare(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int formingMagicSquare(List<List<int>> s)
        {
            Console.WriteLine(s);
            Console.WriteLine(s[0][1]);
            Console.WriteLine(s[1][1]);
            return 1;
        }
    }
}

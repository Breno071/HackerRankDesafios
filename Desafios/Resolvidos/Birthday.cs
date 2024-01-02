using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class Birthday
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = birthday(s, d, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int birthday(List<int> s, int d, int m)
        {
            int qtd = 0;

            for (int i = 0; i < s.Count; i++)
            {
                if(m == 1)
                {
                    if(s.Any(x => x == d))
                    {
                        qtd = s.Count(x => x == d);
                    }
                }
                else
                {
                    if(i + m <= s.Count)
                    {
                        if (s.GetRange(i, m).Sum() == d)
                        {
                            qtd++;
                        }
                    }
                }
            }

            return qtd;
        }
    }
}

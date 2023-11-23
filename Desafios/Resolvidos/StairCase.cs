using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class StairCase
    {
        public static void Init()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            staircase(n);
        }

        private static void staircase(int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                for (int c = 0; c < n - i; c++)
                {
                    stringBuilder.Append(' ');
                }
                for (int j = 0; j < i; j++)
                {
                    stringBuilder.Append('#');

                }
                stringBuilder.Append('\n');
            }
            Console.WriteLine(stringBuilder);
        }
    }
}

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

        public static int formingMagicSquare(List<List<int>> s)
        {
            List<List<List<int>>> possibilitys = new()
            {
                 new List<List<int>>
                {
                    new List<int> { 8, 1, 6 },
                    new List<int> { 3, 5, 7 },
                    new List<int> { 4, 9, 2 }
                },

                new List<List<int>>
                {
                    new List<int> { 6, 1, 8 },
                    new List<int> { 7, 5, 3 },
                    new List<int> { 2, 9, 4 }
                },

                new List<List<int>>
                {
                    new List<int> { 4, 9, 2 },
                    new List<int> { 3, 5, 7 },
                    new List<int> { 8, 1, 6 }
                },

                new List<List<int>>
                {
                    new List<int> { 2, 9, 4 },
                    new List<int> { 7, 5, 3 },
                    new List<int> { 6, 1, 8 }
                },

                new List<List<int>>
                {
                    new List<int> { 8, 3, 4 },
                    new List<int> { 1, 5, 9 },
                    new List<int> { 6, 7, 2 }
                },

                new List<List<int>>
                {
                    new List<int> { 4, 3, 8 },
                    new List<int> { 9, 5, 1 },
                    new List<int> { 2, 7, 6 }
                },

                new List<List<int>>
                {
                    new List<int> { 6, 7, 2 },
                    new List<int> { 1, 5, 9 },
                    new List<int> { 8, 3, 4 }
                },

                new List<List<int>>
                {
                    new List<int> { 2, 7, 6 },
                    new List<int> { 9, 5, 1 },
                    new List<int> { 4, 3, 8 }
                }
            };

            int cost = int.MaxValue;

            for (int i = 0; i < possibilitys.Count; i++)
            {
                int current_cost = 0;
                for (int j = 0; j < possibilitys[i].Count; j++)
                {
                    for (int c = 0; c < possibilitys[i][j].Count; c++)
                    {
                        current_cost += Math.Abs(s[j][c] - possibilitys[i][j][c]);
                    }

                }
                if (current_cost < cost)
                {
                    cost = current_cost;
                }
            }


            return Math.Abs(cost);
        }
    }
}

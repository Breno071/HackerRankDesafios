using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class BreakingRecords
    {
        internal static void Init()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = breakingRecords(scores);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        private static List<int> breakingRecords(List<int> scores)
        {
            int max = 0;
            int min = 0;

            int minimum = 0;
            int maximum = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                if(i != 0)
                {
                    if (scores[i] > maximum)
                    {
                        maximum = scores[i];
                        max++;
                    }
                    if (scores[i] < minimum)
                    {
                        minimum = scores[i];
                        min++;
                    }
                }
                else
                {
                    minimum = scores[i];
                    maximum = scores[i];
                }
            }

            return new List<int>()
            {
                max,
                min
            };
        }
    }
}

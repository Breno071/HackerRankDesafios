using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class ClimbingLeaderboard
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            climbingLeaderboard(ranked, player);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            HashSet<int> newRank = new();

            for (int i = 0; i < ranked.Count; i++)
            {
                newRank.Add(ranked[i]);
            }

            var rank = newRank.ToList();
            rank.Sort();
            rank.Reverse();
            player.Sort();
            player.Reverse();

            List<int> answr = new();
            int c = 0;

            for (int j = 0; j < player.Count; j++)
            {
                while (c < rank.Count && player[j] < rank[c])
                {
                    c++;
                }
                answr.Add(c + 1);
            }
            answr.Reverse();
            return answr;
        }
    }
}

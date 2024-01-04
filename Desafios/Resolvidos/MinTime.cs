using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class MinTime
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int filesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> files = new List<int>();

            for (int i = 0; i < filesCount; i++)
            {
                int filesItem = Convert.ToInt32(Console.ReadLine().Trim());
                files.Add(filesItem);
            }

            int numCores = Convert.ToInt32(Console.ReadLine().Trim());

            int limit = Convert.ToInt32(Console.ReadLine().Trim());

            minTime(files, numCores, limit);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static long minTime(List<int> files, int numCores, int limit)
        {
            var divisibleByCore = files.FindAll(x => x % numCores == 0);
            files.Sort();
            files.Reverse();
            long result = 0;

            for (int i = 0; i < files.Count; i++)
            {
                if(limit > 0)
                {
                    if (files[i] % numCores == 0)
                    {
                        files[i] = files[i] / numCores;
                        limit--;
                    }
                }
            }

            for (int j = 0; j < files.Count; j++)
            {
                result += files[j];
            }

            return result;
        }
    }
}

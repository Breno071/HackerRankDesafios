using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class MigratoryBirds
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int migratoryBirds(List<int> arr)
        {
            int type1 = 0;
            int type2 = 0;
            int type3 = 0;
            int type4 = 0;
            int type5 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                switch (arr[i])
                {
                    case 1:
                        type1++;
                        break;
                    case 2:
                        type2++;
                        break;
                    case 3:
                        type3++;
                        break;
                    case 4:
                        type4++;
                        break;
                    case 5:
                        type5++;
                        break;
                }
            }

            var counts = new List<int>() { type1, type2, type3, type4, type5 };
            var biggest = counts.IndexOf(counts.Max()) + 1;

            return biggest;
        }
    }
}

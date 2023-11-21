
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class AVeryBigSum
    {
        public static void Init()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = AVeryBigSum.aVeryBigSum(ar);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static long aVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }
    }
}

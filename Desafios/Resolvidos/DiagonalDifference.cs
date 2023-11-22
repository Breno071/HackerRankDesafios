using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class DiagonalDifference
    {
        public static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);
            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            var diagonalA = 0;
            var diagonalB = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                diagonalA += arr[i][i];
                diagonalB += arr[i][arr.Count - 1 - i];
            }

            return Math.Abs(diagonalB - diagonalA);
        }
    }
}

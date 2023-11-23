using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class PlusMinus
    {
        public static void Init()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }

        internal static void plusMinus(List<int> arr)
        {
            double positivos = 0;
            double negativos = 0;
            double zeros = 0;
            foreach (var item in arr)
            {
                if (item > 0) positivos += 1;
                if (item < 0) negativos += 1;
                if (item == 0) zeros += 1;
            }

            double positivosPorcentagem = positivos / arr.Count;
            double negativosPorcentagem = negativos / arr.Count;
            double zerosPorcentagem = zeros / arr.Count;
            Console.WriteLine(positivosPorcentagem.ToString("F6"));
            Console.WriteLine(negativosPorcentagem.ToString("F6"));
            Console.WriteLine(zerosPorcentagem.ToString("F6"));
        }
    }
}

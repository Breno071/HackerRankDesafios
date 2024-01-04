using Desafios.Desafios.Resolvidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.NaoResolvidos
{
    public class FilledOrders
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int orderCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> order = new List<int>();

            for (int i = 0; i < orderCount; i++)
            {
                int orderItem = Convert.ToInt32(Console.ReadLine().Trim());
                order.Add(orderItem);
            }

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            filledOrders(order, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int filledOrders(List<int> order, int k)
        {
            order.Sort();
            int contador = 0;
            int resultado = 0;
            foreach (var item in order)
            {
                if (order[0] == k)
                {
                    contador++;
                    break;
                }
                resultado += item;
                contador++;

                if(resultado == k)
                {
                    break;
                }
                else if(resultado > k)
                {
                    resultado -= item;
                    contador--;
                    break;
                }
            }

            return contador;
        }
    }
}

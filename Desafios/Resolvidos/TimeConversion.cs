using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class TimeConversion
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static string timeConversion(string? s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "00:00:00";
            }

            DateTime.TryParse(s, out DateTime time);
            Console.WriteLine(time.TimeOfDay);
            return time.TimeOfDay.ToString();
        }
    }
}

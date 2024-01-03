using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class DayOfProgrammer
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            dayOfProgrammer(year);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static string dayOfProgrammer(int year)
        {
            bool gragorianCalendar = false;
            string dayOfProgramer;
            bool anoCentenario = false;

            if (year >= 1919)
                gragorianCalendar = true;

            if (year.ToString().Length > 2)
            {
                var ultimosDoisDigitos = year.ToString().Substring(2, 2);

                if (ultimosDoisDigitos.Equals("00"))
                {
                    anoCentenario = true;
                }
            }

            if (gragorianCalendar)
            {
                dayOfProgramer = "13.09." + year;

                if (anoCentenario && year % 400 == 0)
                {
                    dayOfProgramer = "12.09." + year;
                }
                else
                {
                    if (year % 4 == 0 && !anoCentenario)
                    {
                        dayOfProgramer = "12.09." + year;
                    }
                }
            }
            else
            {
                dayOfProgramer = "13.09." + year;
                if (year % 4 == 0)
                {
                    dayOfProgramer = "12.09." + year;
                }
            }

            if (year == 1918)
            {
                dayOfProgramer = "26.09.1918";
            }

            return dayOfProgramer;
        }
    }
}

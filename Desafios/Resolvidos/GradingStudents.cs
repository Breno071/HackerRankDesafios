using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    public class GradingStudents
    {
        internal static void Init()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new();

            foreach (int grade in grades)
            {
                var multiploDe5 = GetNextFiveMultiplier(grade);
                if (multiploDe5 < 40) result.Add(grade);
                else if (multiploDe5 - grade >= 3) result.Add(grade);
                else if (multiploDe5 - grade < 3) result.Add(multiploDe5);
            }

            return result;
        }

        private static int GetNextFiveMultiplier(int grade)
        {
            var resto = (double)grade % 5;
            var sobra = (int)Math.Ceiling(resto);
            return grade + (5 - sobra);
        }
    }
}

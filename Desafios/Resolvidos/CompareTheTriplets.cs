using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Desafios.Resolvidos
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            int[] result = new int[2];
            if (a.Count == b.Count)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        alice++;
                    }
                    else if (a[i] < b[i])
                    {
                        bob++;
                    }
                }
            }
            result[0] = alice;
            result[1] = bob;
            return result.ToList();
        }
    }

    class CompareTheTriplets
    {
        public static void Init(string[] args)
        {
            //@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            Result.compareTriplets(a, b);
            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

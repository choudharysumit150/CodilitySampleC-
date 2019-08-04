using CodilitySampleTest.BinaryGap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilitySampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codility Sample Tests");
            Console.WriteLine("Binary Gap Problem");

            int binaryGapResult = Solution.solution(32);
            Console.WriteLine("Maximum Bainary Gap : " + binaryGapResult);
            Console.ReadLine();
        }
    }
}

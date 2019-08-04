using CodilitySampleTest.BinaryGap;
using CodilitySampleTest.FrogJmp;
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

            int binaryGapResult = BinaryGap.Solution.solution(75986);
            Console.WriteLine("Maximum Bainary Gap : " + binaryGapResult);

            Console.WriteLine("Frog Jmp Problem");
            int minimStepsRequired = FrogJmp.Solution.solution(20,150,7);
            Console.WriteLine("Minimum Jumps required by Frog: " + minimStepsRequired);

            Console.ReadLine();
        }
    }
}

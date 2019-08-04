using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Problem Statement  : https://codility.com/programmers/lessons/1-iterations/binary_gap/
/// </summary>
namespace CodilitySampleTest.BinaryGap
{
  public static class Solution
    {
        public static int solution(int N)
        {
            if (!Convert.ToString(N, 2).Contains("0"))
            {
                return 0;
            }
            if ((Convert.ToString(N, 2).Split('1')).Length==2)
            {
                return 0;
            }
            ArrayList zerosList = getBinaryData(N);


            return getMaxGap(zerosList);
        }

        public static int getMaxGap(ArrayList zerosList)
        {
            int maximumGap = 0;

            foreach (String s in zerosList)
            {
               // Console.WriteLine("String with zeros : " + s);
                if (s.Length > maximumGap)
                {
                    maximumGap = s.Length;
                }
            }

            return maximumGap;
        }
        public static ArrayList getBinaryData(int N)
        {
            string binaryForm = Convert.ToString(N, 2);
            Console.WriteLine("Binary Converison of " + N + "is :" + binaryForm);
            string[] binaryArray = binaryForm.Split('1').ToArray();

            ArrayList zerosList = new ArrayList(binaryArray);


            // Handle corner cases like 000000100001
            if (binaryForm.StartsWith("0") && zerosList.Count > 0)
            {
                zerosList.RemoveAt(0);
            }

            // Handle corner cases like 100100000
            if (binaryForm.EndsWith("0") && zerosList.Count > 0)
            {
                zerosList.RemoveAt(zerosList.Count - 1);
            }
            return zerosList;
        }
    }
}

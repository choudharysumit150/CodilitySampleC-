using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Problem Statement :https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
/// </summary>
namespace CodilitySampleTest.FrogJmp
{
    public static class Solution
    {
        public static int solution(int X, int Y, int D)
        {
            if (X == Y || D<0)
            {
                return 0;
            }

            return getMinimumSteps(X, Y, D);
        }
        public static int getMinimumSteps(int fromPoint, int toPoint, int distanceInEachStep)
        {
            int minimumSteps = 0;


            double totalDistance = toPoint - fromPoint;
            if (totalDistance < distanceInEachStep)

                return 1;

            minimumSteps =(int) Math.Ceiling(totalDistance / distanceInEachStep);
            return minimumSteps;
        }
    }
}

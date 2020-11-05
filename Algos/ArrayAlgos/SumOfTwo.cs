using System;
namespace Algos.ArrayAlgos
{
    public class SumOfTwo
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currSum = array[left] + array[right];
                if (currSum == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }
                else if (currSum < targetSum)
                {
                    left++;
                }
                else if (currSum > targetSum)
                {
                    ;
                    right--;
                }
            }
            return new int[0];
        }
    }
}
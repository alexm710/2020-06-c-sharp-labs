using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            int maxNum = nums[0];
            int i = 1;
            while (i < nums.Length)
            {
                if (nums[i] > maxNum) maxNum = nums[i];
                i++;
            }
            return maxNum;
        }
    }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            throw new NotImplementedException();
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            throw new NotImplementedException();
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            throw new NotImplementedException();
        }
    }
}
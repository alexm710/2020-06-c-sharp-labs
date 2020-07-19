namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int highest = int.MinValue;
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int highest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > highest) highest = nums[i];
            }
            return highest;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int highest = nums[0];
            foreach (int num in nums)
            {
                if (num > highest) highest = num;
            }
            return highest;
        }
        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            int highest = nums[0];
            int i = 1;
            do
            {
                if (nums[i] > highest) highest = nums[i];
                i++;
            }
            while (i < nums.Length);
            return highest;
        }
    }
}
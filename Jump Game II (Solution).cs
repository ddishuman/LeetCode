public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length <= 1)
            return 0;

        int i = 0, curentMax = 0, nextMax = 0, step = 0;

        // BFS
        while (i < curentMax + 1)  // # of nodes of current step
        {
            step++;
            for (; i <= curentMax; i++)  // loop current node's every next step
            {
                nextMax = Math.Max(nextMax, nums[i] + i);
                if (nextMax >= nums.Length - 1) return step;
            }

            curentMax = nextMax;
        }

        return 0;
    }

}
public class Solution {
   public int FindUnsortedSubarray(int[] nums) {
        int beginidx = 0;
        int endidx = 0;
        int max = nums[0];
        int min =nums[nums.Length-1];

        for(int i =0;i<nums.Length;i++)
        {
            //maintain max
            if(nums[i]>=max)
            {
                max= nums[i];
            }
            else
            {
                endidx = i;
            }

            //maintain min
            if(nums[nums.Length-1 - i]<=min)
            {
                min= nums[nums.Length-1 - i];
            }
            else
            {
                beginidx = nums.Length-1 - i;
            }
        }
        return endidx==beginidx?0:endidx-beginidx+1;
    }
}
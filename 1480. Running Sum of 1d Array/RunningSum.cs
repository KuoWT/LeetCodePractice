public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] results =new int[nums.Length];
        int temp =0;
        for(int i =0;i<nums.Length;i++)
        {
            results[i] = temp + nums[i];
            temp = results[i];
        }
        return results;
    }
}
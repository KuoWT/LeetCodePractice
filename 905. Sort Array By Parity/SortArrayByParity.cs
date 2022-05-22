public class Solution {
     public int[] SortArrayByParity(int[] nums) {
        int[] res = new int[nums.Length];
        int endidx =0;
        int startidx =0;


        for(int i =0;i<nums.Length;i++)
        {
            if(nums[i]%2==0)
            {
                res[startidx] = nums[i];
                startidx++;
            }
            else
            {

                res[nums.Length-1-endidx] = nums[i];
                endidx++;
            }
        }
        return res;
    }
}
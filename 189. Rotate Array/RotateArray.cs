public class Solution {
    public class Solution {
        public void Rotate(int[] nums, int k){
            
            int[] temp = new int[nums.Length];
            k = k%(nums.Length);
            Array.Copy(nums, 0, temp,k, nums.Length-k);
            Array.Copy(nums, nums.Length-k, temp, 0, k);
            Array.Copy(temp, nums,nums.Length);
        }
    }
}
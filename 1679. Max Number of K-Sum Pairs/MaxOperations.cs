public class Solution {
    public int MaxOperations(int[] nums, int k)
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        //not contain then add item
                        dic.Add(nums[i], 1);
                    }
                    else 
                    {
                        dic[nums[i]] = dic[nums[i]] + 1;
                    }

                    int remain = k - nums[i];
                    //search remain
                    if (dic.ContainsKey(remain))
                    {
                        if (remain == nums[i])
                        {
                            count = count + dic[remain] / 2;
                            dic[remain] = dic[remain] % 2;

                        }
                        else
                        {
                            int mincnt = Math.Min(dic[remain], dic[nums[i]]);
                            dic[remain] = dic[remain] - mincnt;
                            dic[nums[i]] = dic[nums[i]] - mincnt;
                            count = count + mincnt;
                        }
                    }
                    else
                    {

                    }

                }


                return count;


            }
}
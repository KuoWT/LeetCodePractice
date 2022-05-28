public class Solution {
     public int LengthOfLongestSubstring(string s) {
        char[] charArr = s.ToArray();
        int left =0;
        int right =0;
        int maxlen =0;
        Dictionary<char,int> dicChar = new Dictionary<char, int>();
        for(right=0;right<charArr.Count();right++)
        {
            
            if(dicChar.ContainsKey(charArr[right]))
            {
                if(dicChar[charArr[right]]>=left)
                {
                    left = dicChar[charArr[right]]+1;
                }
                dicChar[charArr[right]] = right;
            }
            else
            {
                dicChar.Add(charArr[right],right);
            }
            maxlen = Math.Max(maxlen,right-left+1);
        }
       

        return maxlen;
    }
}
public class Solution {
    //Force
    public string LongestPalindrome(string s) {
     //force
     int n =s.Count();
     string res ="";
     for(int i = 0;i<n;i++)
     {
          for(int j = i;j<n;j++)
          {
               int left = i;int right=j;
               bool isPalindrome = true;
               while(right>left)
               {
                    if(s[right]!=s[left])
                    {
                         isPalindrome = false;
                         break;
                    }
                   right--;
                   left++;
               }
               if(isPalindrome)
               {
                    if(j-i+1>res.Length)
                    {
                         res = s.Substring(i,j-i+1);
                    }
               }

          }
     }
       return res;
    }
}
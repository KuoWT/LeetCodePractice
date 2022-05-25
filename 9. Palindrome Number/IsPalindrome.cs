public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        int temp = x;
        int res = 0;int remain = 0;
       while(temp!=0)
       {
           remain = temp % 10;
           temp = temp/10;
           res = res*10+remain;
           
       }
        return x==res?true:false;
    }
}
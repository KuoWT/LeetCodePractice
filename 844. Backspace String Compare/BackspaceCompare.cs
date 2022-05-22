public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return function(s)==function(t)? true:false;
    }
    
    public string function(string str)
    {
        Stack<char> stk =new Stack<char>();
        char[] CharArray = str.ToCharArray ();
        for(int i = 0;i<CharArray.Length;i++)
        {
             if(CharArray[i]=='#')
            {
                if(stk.Count!=0)
                stk.Pop();
                
            }
            else
            {
                stk.Push(CharArray[i]);
            }
        }
        return  string.Join("",stk.ToArray());
    }
}
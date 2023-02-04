public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        if (x < 0) return false;
        if (x == 0) return true;
        
        char[] chars = x.ToString().ToCharArray();
        int l = 0, r = chars.Length - 1;
        
        while (l <= r)
        {
            if (chars[l] != (chars[r])) return false;
            
            l ++;
            r --;
        }
        
        return true;
    }
}

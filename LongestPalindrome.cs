public class Solution 
{
    public string LongestPalindrome (string s) 
    {    
        string res = string.Empty;
        
        if (s.Length < 2) 
        {
            return s;
        }
        
        for (int i = 0 ; i < s.Length ; i ++)
        {
            for (int j = 1 ; j <= s.Length - i; j ++)
            {
                if (j <= res.Length) 
                {
                    continue;
                }
                
                if (IsPalindromic(s.Substring(i, j)))
                {
                    if (res.Length < j)
                    {
                        res = s.Substring(i, j);
                    }
                }
            }
        }
        
        return res;
    }
    
    bool IsPalindromic (string s)
    {
        int start = 0, end = s.Length - 1;
        
        while (start<= end)
        {
            if (s[start ++] != s[end --]) 
            {
                return false;
            }
        }
        
        return true;
    }
}

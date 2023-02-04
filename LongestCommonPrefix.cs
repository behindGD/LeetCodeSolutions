public class Solution 
{
    public string LongestCommonPrefix(string[] strs)
    {
        for (int i = 0; i < strs[0].Length; i++) 
        {
            char curr = strs[0][i];
            
            for (int j = 0; j < strs.Length; j++) 
            {
                if (strs[j].Length == i || strs[j][i] != curr) 
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        
        return strs[0]; 
    }
}

public class Solution 
{
    public bool IsValid(string s) 
    {    
        Dictionary<char, char> dic = new();
        
        dic.Add('[', ']');
        dic.Add('{', '}');
        dic.Add('(', ')');
        
        Stack<char> stack = new();
        
        foreach (char c in s)
        {
            if (dic.ContainsKey(c)) 
            {
                stack.Push(dic[c]);
            }
            else if (stack.Count == 0 || stack.Pop() != c) 
            {
                return false;
            }
        }
        
        return stack.Count == 0;
    }
}

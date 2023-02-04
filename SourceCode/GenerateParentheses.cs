public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        List<string> res = new();
        char[] buffer = new char[n * 2];
        
        Helper(n, res, 1, 0, buffer, '(');
        
        return res;
    
        void Helper(int n, List<string> res, int opened, int closed, char[] buffer, char c)
        {
            if (closed > opened || opened > n)
            {
                return;
            }

            buffer[opened + closed - 1] = c;

            if (closed == n)
            {
                res.Add(new string(buffer));
            }

            Helper(n, res, opened + 1, closed, buffer, '(');
            Helper(n, res, opened, closed + 1, buffer, ')');
        }
    }
}

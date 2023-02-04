public class Solution 
{
    public int Reverse(int x) 
    {
        bool isPos = x > 0 ? true : false;
        x = (x > 0) ? x : (x * -1);

        char[] chars = x.ToString().ToCharArray();
        
        Array.Reverse(chars);
        
        if (!Int32.TryParse(new string(chars), out x))
        {
            return 0;
        }

        return isPos ? x : (x * -1);
    }
}

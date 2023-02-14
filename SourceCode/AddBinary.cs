public class Solution 
{
    public string AddBinary(string a, string b)
	{
        List<char> sum = new List<char>();
        bool carry = false;
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        while (i >= 0 || j >= 0)
        {
            int pos = 0;
            if (i >= 0) 
            {
                pos += a[i] - '0'; 
                i--;
            }
            if (j >= 0) 
            {
                pos += b[j] - '0'; 
                j--;
            } 
            pos += carry ? 1 : 0;            
            carry = (pos >= 2);
            
            sum.Insert(0, pos % 2 == 0 ? '0' : '1');
        }
        
        if (carry) sum.Insert(0, '1'); 
        return new string(sum.ToArray());
    }
}

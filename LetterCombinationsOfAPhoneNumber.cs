public class Solution 
{
    public IList<string> LetterCombinations(string digits) 
    {        
        IList<string> res = new List<string>();
        if (digits == "") return res;
        string[] map = new string[10]
        {
            "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
        };
                
        IEnumerable<string> list = new List<string> { "" };

        foreach (var set in digits.ToCharArray().Select(a => map[a - 48]))
        {
            list = list.SelectMany(a => set.Select(b => a + b));
        }

        return list.ToList();
    }
}

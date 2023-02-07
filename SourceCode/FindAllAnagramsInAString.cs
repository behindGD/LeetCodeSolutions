public class Solution 
{
    public IList<int> FindAnagrams(string s, string p) 
    {
        IList<int> res = new List<int>();
        if (p.Length > s.Length) return res;
        int[] freqP = new int[26];
        int[] freqS = new int[26];
        for (int i = 0; i < p.Length; i++)
        {
            freqP[p[i] - 97]++;
            freqS[s[i] - 97]++;
        }
        for (int i = 0; i < s.Length - p.Length + 1; i++)
        {
            if (i > 0)
            {
                freqS[s[i - 1] - 97]--;
                freqS[s[i + p.Length - 1] - 97]++;
            }
            if (Enumerable.SequenceEqual(freqP, freqS)) res.Add(i);
        }
        return res;
    }
}

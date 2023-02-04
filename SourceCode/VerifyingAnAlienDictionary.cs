public class Solution 
{
    public bool IsAlienSorted(string[] words, string order) 
    {
        for (int i = 0; i < words.Length - 1; i++)
            if (!Sorted(words[i], words[i + 1], order, 0)) return false;
        return true;
    }

    bool Sorted(string s1, string s2, string order, int i)
    {
        while (i < s1.Length && i < s2.Length)
        {
            if (s1[i] == s2[i]) i++;
            else return order.IndexOf(s1[i]) <= order.IndexOf(s2[i]) ? true : false;
        }
        return s1.Length <= s2.Length ? true : false;
    }
}

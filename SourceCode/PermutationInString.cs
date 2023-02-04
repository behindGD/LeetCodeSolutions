public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length) return false;
        if (s1.Length == 1) return s2.Contains(s1);
        int[] s1Freq = new int[26], s2Freq = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            s1Freq[s1[i] - 97]++;
            s2Freq[s2[i] - 97]++;
        }
        int left = 0, right = s1.Length - 1;
        while (right < s2.Length)
        {
            if (left != 0)
            {
                s2Freq[s2[left - 1] - 97]--;
                s2Freq[s2[right] - 97]++;
            }    
            if (Enumerable.SequenceEqual(s1Freq, s2Freq)) return true;
            left++; 
            right++;
        }
        return false;
    }
}

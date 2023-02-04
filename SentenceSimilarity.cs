public class Solution 
{
    public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs) 
    {
        if (sentence1.Length != sentence2.Length) return false;
        if (similarPairs.Count == 0) return true;
        bool[] safe = new bool[sentence1.Length];
        for (int i = 0; i < sentence1.Length; i++)
        {
            if (sentence1[i] == sentence2[i])
            {
                safe[i] = true;
                continue;
            }
            for (int j = 0; j < similarPairs.Count; j++)
            {
                if (similarPairs[j].Contains(sentence1[i]) && similarPairs[j].Contains(sentence2[i]))
                {
                    safe[i] = true;
                }
            }
           
        }
        foreach (bool s in safe)
        {
            if (!s) return false;
        }
        return true;
    }
}

public class Solution 
{
    public IList<int> FindSubstring(string s, string[] words) 
    {
        List<int> result=new List<int>();
        int sizeofeachword=words[0].Length;
        int sizeofallhwords=words[0].Length * words.Length;
        if(s.Length<sizeofallhwords) return result;

        var map=new Dictionary<string,int>();
        foreach(string thisword in words)
        {
            map[thisword]=map.ContainsKey(thisword)? map[thisword]+1:1;
        }

        for(int i=0;i<s.Length-sizeofallhwords+1;i++)
        {
            var map1=new Dictionary<string,int>();
            bool isBreaked=false;
            for(int j=i;j<i+sizeofallhwords;j=j+sizeofeachword)
            { 
                string currstr=s.Substring(j,sizeofeachword);
                if(map.ContainsKey(currstr))
                {
                    map1[currstr]=map1.ContainsKey(currstr)? map1[currstr]+1:1;
                    if(map1[currstr]>map[currstr])
                    {
                        isBreaked=true;
                        break;
                    }
                }
                else
                {
                    isBreaked=true;
                    break;
                }
            }
            if(!isBreaked)
            {
                result.Add(i);
            }
        }
        return result;
    }
}

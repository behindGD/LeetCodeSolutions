public class Solution 
{
    public string Convert(string s, int numRows) 
    {
        if (numRows == 1) return s;
        char[][] matrix = new char[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            matrix[i] = new char[(int)Math.Ceiling(s.Length / (numRows * 2 - 2.0)) * (numRows - 1)];
            Array.Fill(matrix[i], '0');
        }
        int row = 0, col = 0, indexOfS = 0;
        StringBuilder res = new();
        while (indexOfS < s.Length)
        {
            while (row < numRows && indexOfS < s.Length)
            {
                matrix[row][col] = s[indexOfS];
                row++;
                indexOfS++;
            }
            row -= 2;
            col++;
            while (row > 0 && col < matrix[0].Length && indexOfS < s.Length)
            {
                matrix[row][col] = s[indexOfS];
                row--;
                col++;
                indexOfS++;
            }
        }
        foreach (char[] sub in matrix)
            foreach (char c in sub)
                if (c != '0') res.Append(c);
        return res.ToString();
    }
}

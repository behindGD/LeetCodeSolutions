public class Solution 
{
    public string IntToRoman(int num) 
    {
        if (num >= 1000) return "M" + IntToRoman(num - 1000);
        if (num >= 500) return num >= 900 ? ("CM" + IntToRoman(num - 900)) : ("D" + IntToRoman(num - 500));
        if (num >= 100) return num >= 400 ? ("CD" + IntToRoman(num - 400)) : ("C" + IntToRoman(num - 100));
        if (num >= 50) return num >= 90 ? ("XC" + IntToRoman(num - 90)) : ("L" + IntToRoman(num - 50));
        if (num >= 10) return num >= 40 ? ("XL" + IntToRoman(num - 40)): ("X" + IntToRoman(num - 10));
        if (num >= 5) return num == 9 ? "IX" : "V" + IntToRoman(num - 5);
        if (num > 0) return num == 4 ? "IV" : "I" + IntToRoman(num - 1);
        return "";
    }
}

using System.Text;
using System;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        
        s = s.ToLower();
        var builder = new StringBuilder();
        foreach (var item in s)
        {
            if (char.IsLetterOrDigit(item))
            {
                builder.Append(item);
            }
        }
        string s1 = builder.ToString();
        char[] arr = s1.ToCharArray();
        Array.Reverse(arr);
        string s2 = new string(arr);
        return s1 == s2;

    }
}

using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
char[] a = my_string.ToCharArray();
for(int i = 0; i < a.Length; i++)
{
    if (Char.IsLower(a[i]))
    {
        answer += a[i].ToString().ToUpper();
    }
    else
    {
        answer += a[i].ToString().ToLower();
    }
}

return answer;
    }
}
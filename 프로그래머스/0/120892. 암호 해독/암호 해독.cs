using System;
using System.Linq;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
char[] a = new char[cipher.Length];
a = cipher.Select(x => x).ToArray();
for(int i = code-1; i < a.Length; i += code)
{
    answer += a[i];
}
return answer;
    }
}
using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
string d = "";
char[] a = new char[my_string.Length];
a = my_string.Select(x => x).ToArray();
for (int i = 0; i < a.Length; i++)
{
    if (int.TryParse(a[i].ToString(), out int k))
    {
        d += a[i].ToString();

    }
    else
    {
        bool s = int.TryParse(d, out int zx);
        answer += zx;
        d = "";
    }
}
bool ww = int.TryParse(d, out int zsx);
answer += zsx;
return answer;
    }
}
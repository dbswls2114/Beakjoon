using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        string a = n.ToString();
long[] ans = new long[a.Length];
int i = 0;
while (n > 0)
{
    ans[i] = n % 10;

    n = n / 10;
    i++;
}
Array.Sort(ans);
Array.Reverse(ans);
string b = null;
foreach (long ar in ans)
{
    b += ar.ToString();
}
long answer = long.Parse(b);
return answer;
    }
}
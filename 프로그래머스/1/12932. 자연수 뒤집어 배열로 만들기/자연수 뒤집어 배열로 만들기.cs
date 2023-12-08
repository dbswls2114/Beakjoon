using System;
using System.Linq;
public class Solution {
    public long[] solution(long n) {
        string a = n.ToString();
long[] answer = new long[a.Length];
int i = 0;
while (n > 0)
{
    answer[i] = n % 10;

    n = n / 10;
    i++;
}
//Array.Sort(answer);
//Array.Reverse(answer);
foreach (long ar in answer)
{
    Console.WriteLine(ar);
}
return answer;
    }
}
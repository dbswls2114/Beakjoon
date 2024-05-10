using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
char[] a = new char[my_string.Length];
a = my_string.Select(x => x).ToArray();
foreach(char x in a)
{
    int b = 0;
    int.TryParse(x.ToString(), out b);
    answer += b;  
}
return answer;
    }
}
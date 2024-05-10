using System;
using System.Linq;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
char[] a = new char[rsp.Length];         
a = rsp.Select(x => x).ToArray();
foreach(char x in a)
{
    switch (x)
    {
        case '0' : answer += "5"; break;
        case '2' : answer += "0"; break;
        case '5' : answer += "2"; break;
    }
}
return answer;
    }
}
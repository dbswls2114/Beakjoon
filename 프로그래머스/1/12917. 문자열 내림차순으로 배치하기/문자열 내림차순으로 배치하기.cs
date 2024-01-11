using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        char[] a = s.ToCharArray();
            Array.Sort(a);
            Array.Reverse(a);
            string answer = new string(a);
            return answer;
    }
}
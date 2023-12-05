using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        string a = n.ToString();
        int[] arr = new int[a.Length];
        int i = 0;
        while (n > 0)
{
    arr[i] = n % 10;

    n = n / 10;
    i++;
}
        int answer = arr.Sum();
return answer;
    }
}
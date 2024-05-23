using System;

public class Solution {
    public int solution(int[] numbers) {
        int[] a = numbers;
Array.Sort(a);
Array.Reverse(a);
int answer = a[0] * a[1];
return answer;
    }
}
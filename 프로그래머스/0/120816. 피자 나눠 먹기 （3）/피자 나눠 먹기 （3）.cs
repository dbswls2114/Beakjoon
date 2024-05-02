using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 1;
int a = slice;
while (a * answer < n)
{
    answer++;
}
return answer;
    }
}
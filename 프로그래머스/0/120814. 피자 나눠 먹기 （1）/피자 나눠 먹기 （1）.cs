using System;

public class Solution {
    public int solution(int n) {
       int answer = 1;
int a = n;
while (a > 7)
{
    a-=7; answer++;
}
return answer;
    }
}
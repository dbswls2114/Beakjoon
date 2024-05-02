using System;

public class Solution {
    public int solution(int n) {
       int answer = 1;
int a = 6;
while (a % n != 0 )
{
    a += 6;
    answer++;
}
return answer;
    }
}
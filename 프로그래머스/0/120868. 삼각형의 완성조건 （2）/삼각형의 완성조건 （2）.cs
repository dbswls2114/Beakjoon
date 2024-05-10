using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
Array.Sort(sides, (num1, num2) => num1 > num2 ? -1 : 1);
for (int i = 1; sides[0] > i; i++)
{
    if (sides[0] < i + sides[1])
    answer++;
}
for(int j = sides[0]; sides[0] + sides[1]>j; j++)
{
    answer++;
}
return answer;
    }
}
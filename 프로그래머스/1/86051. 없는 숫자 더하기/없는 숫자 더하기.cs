using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j <= 9; j++)
    {
        if (numbers[i] == j)
        {
            answer -= j;
            break;
        }                    
    }
    
}
return answer;
    }
}
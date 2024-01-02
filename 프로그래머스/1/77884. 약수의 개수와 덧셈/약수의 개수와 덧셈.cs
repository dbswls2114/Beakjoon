using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;

for (int a = left; a <= right; a++) 
{
    int count = 0;
    for (int b = 1; b <= a; b++)
    {
        if (a % b == 0)
        {
            count++;
            Console.WriteLine(b);
        }
    }

    if(count % 2 == 0)
    {
        answer += a;
    }
    else
    {
        answer -= a;
    }
}
return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int count = 0;
int[] answer;
answer = new int[numbers.Length];
foreach (int i in numbers)
{
    answer[count] = i*2;
    count++;
}
return answer;
    }
}
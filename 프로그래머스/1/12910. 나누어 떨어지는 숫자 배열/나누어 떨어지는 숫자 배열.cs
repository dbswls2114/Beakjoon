using System;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % divisor == 0)
    {
        count++;
    }
}

if (count == 0)
{
    return new int[] { -1 };
}

int[] answer = new int[count];
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % divisor == 0)
    {
        answer[index++] = arr[i];
    }
}

Array.Sort(answer);
return answer;
    }
}
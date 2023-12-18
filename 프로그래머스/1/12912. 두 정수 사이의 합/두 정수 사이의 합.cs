public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
int min = a < b ? a:b;
int max = a < b ? b:a;
while (min <= max)
{
    answer += (long)min;
    min++;
}
return answer;
    }
}
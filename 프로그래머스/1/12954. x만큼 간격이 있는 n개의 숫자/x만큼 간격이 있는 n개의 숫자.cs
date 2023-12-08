public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
int a = 1;
for(int i = 0; i < n; i++)
{
    answer[i] = (long)x*(i+a);               
}

return answer;
    }
}
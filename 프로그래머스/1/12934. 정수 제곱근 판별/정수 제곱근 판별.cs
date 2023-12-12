public class Solution {
    public long solution(long n) {
        
        long answer = 0;
        for (long i = 0; i <= n; i++)
        {
            if(i*i == n)
            {
                answer = i;
                break;
            }
        }
    return answer==0?-1:(answer+1)*(answer+1);
    }
}
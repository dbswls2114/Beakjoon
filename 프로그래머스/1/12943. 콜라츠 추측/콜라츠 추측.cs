public class Solution {
    public long solution(long num) {
        long answer = 0;
while (num != 1 && answer < 500)
{
    num = num % 2 == 0? num/2 : num*3+1;               
    answer++;
}
return _ = answer < 500? answer:-1;
    }
}
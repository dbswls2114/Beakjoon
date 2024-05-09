using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;

if(price < 100000)
{
    return price;
}else if(price < 300000)
{
    return (int)Math.Truncate(price - price * 0.05);
}else if( price < 500000)
{
    return (int)Math.Truncate(price - price * 0.1);
}else if(price >= 500000)
{
    return (int)Math.Truncate(price - price * 0.2);
}
return answer;
    }
}
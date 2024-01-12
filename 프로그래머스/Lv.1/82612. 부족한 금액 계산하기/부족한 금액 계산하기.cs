using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long a = 0;
            for (int i = 1; i <= count; i++)
            {
                a += price * i;
            }

            return _ = money - a < 0 ? (money - a)*-1 : 0;   ;
    }
}
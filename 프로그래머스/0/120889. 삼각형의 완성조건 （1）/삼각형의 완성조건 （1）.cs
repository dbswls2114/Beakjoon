using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
        int high = 0;
foreach (int side in sides)
{
    if (high < side) high = side;
}
return high >= sides.Sum() - high ? 2 : 1;
    }
}
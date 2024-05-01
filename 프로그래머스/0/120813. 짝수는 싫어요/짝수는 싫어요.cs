using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
list.Add(1);
for (int i = 3; i <= n; i++)
{
    if(i%2 == 1) list.Add(i);
}
return list.ToArray();
    }
}
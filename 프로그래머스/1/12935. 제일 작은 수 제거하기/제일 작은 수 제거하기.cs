using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] a = { -1 };

if (arr.Length <= 1)
{
    return a;
}
List<int> list = new List<int>(arr);
int min = arr.Min();
list.Remove(min);

return list.ToArray();
    }
}
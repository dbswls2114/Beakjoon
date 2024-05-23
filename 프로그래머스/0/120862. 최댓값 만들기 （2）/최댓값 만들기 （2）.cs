using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        numbers = numbers.OrderByDescending(x => x).ToArray();
int answer = numbers[0] * numbers[1] > numbers[numbers.Length - 1] * numbers[numbers.Length-2] ? numbers[0] * numbers[1] : numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
return answer;
    }
}
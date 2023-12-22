using System;

public class Solution {
    public string solution(string[] seoul) {
        int answernum = Array.IndexOf(seoul, "Kim");
string answer = $"김서방은 {answernum}에 있다";
return answer;
    }
}
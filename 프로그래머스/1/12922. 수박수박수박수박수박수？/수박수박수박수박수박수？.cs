public class Solution {
    public string solution(int n) {
        string answer = "";
int a = 0;
while(n > a)
{
    if(a % 2 == 0)
    {
        answer += "수";
    }
    else
    {
        answer += "박";
    }
    a++;               
}

return answer;
    }
}
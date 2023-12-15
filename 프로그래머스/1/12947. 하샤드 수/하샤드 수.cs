public class Solution {
    public bool solution(int x) {
        bool answer = false;
int k = x;
int a = 0;
int i = 0;
while (x > 0)
{
    a += x % 10;

    x = x / 10;
    i++;
}
answer = k % a == 0 ? true : false;
return answer;
    }
}
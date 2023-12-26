public class Solution {
    public string solution(string phone_number) {
        string p = phone_number.Substring(phone_number.Length -4);
int a = (phone_number.Length - p.Length);
string k = "";
for(int i = 0; i < a; i++)
{
    k += "*";
}
string answer = k+p;
return answer;
    }
}
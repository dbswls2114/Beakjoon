public class Solution {
    public string solution(string s, int n) {
        char[] char_s = s.ToCharArray();
int[] ask_s = new int[char_s.Length];
for(int i =0; i < char_s.Length; i++)
{
    ask_s[i] = (int)char_s[i];
    
    if (char.IsLower(char_s[i])) // 소문자인 경우
    {
        if (ask_s[i] + n > 122) // z를 넘어가는 경우
        {
            ask_s[i] = 96 + ((ask_s[i] + n) % 122);
        }
        else
        {
            ask_s[i] += n;
        }
    }
    else if (char.IsUpper(char_s[i])) // 대문자인 경우
    {
        if (ask_s[i] + n > 90) // Z를 넘어가는 경우
        {
            ask_s[i] = 64 + ((ask_s[i] + n) % 90);
        }
        else
        {
            ask_s[i] += n;
        }
    } 
    char_s[i] = (char)ask_s[i];
}

string answer = new string(char_s);
return answer;
    }
}
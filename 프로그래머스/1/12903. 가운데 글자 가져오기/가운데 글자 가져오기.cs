public class Solution {
    public string solution(string s) {
        int l = s.Length;
int h = 0;
if (l % 2 == 0)
{ 
    h = l / 2 -1;
    return s.Substring(h,2);
}
else
{
    h = l / 2;
    return s.Substring(h,1);
}
    }
}
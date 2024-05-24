using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

int[] arry = new int[20000001];
int n = int.Parse(Console.ReadLine());
string[] nstr = Console.ReadLine().Split(' ');

int m = int.Parse(Console.ReadLine());
string[] mstr = Console.ReadLine().Split(' ');
int nIdx = 10000000;
StringBuilder stringBuilder = new StringBuilder();
for (int i = 0; i < nstr.Length; i++)
{
    arry[nIdx + int.Parse(nstr[i])]++;
}
for (int i = 0; i < mstr.Length; i++)
{
    stringBuilder.Append(arry[nIdx + int.Parse(mstr[i])] + " ");
}
Console.WriteLine(stringBuilder.ToString());
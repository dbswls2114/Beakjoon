string[] input = Console.ReadLine().Split();
int x = int.Parse(input[0]);
int y = int.Parse(input[1]);
int minpaint = int.MaxValue;
List<List<char>> index = new List<List<char>>();

for (int i = 0; i < x; i++)
{
    index.Add(Console.ReadLine().ToList());
}


for (int i = 0; i <= x - 8; i++)
{
    for (int j = 0; j <= y - 8; j++)
    {
        int paintW = 0;
        int paintB = 0;
        for (int k = i; k < i + 8; k++)
        {
            for (int l = j; l < j + 8; l++)
            {
                if ((k + l) % 2 == 0) //짝수자리를
                {
                    if (index[k][l] != 'W') 
                    {
                        paintW++; //전부 W로 채울때
                    }
                    else
                    {
                        paintB++; //전부 B로 채울때
                    }
                }
                else                //홀수 자리의
                {
                    if (index[k][l] != 'W')
                    {
                        paintB++; //B의 개수
                    }
                    else
                    {
                        paintW++; //W의 개수
                    }
                }
            }
        }
        if (minpaint > paintW) { minpaint = paintW; }
        if (minpaint > paintB) { minpaint = paintB; }
    }
}
Console.WriteLine(minpaint);
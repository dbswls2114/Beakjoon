int input = int.Parse(Console.ReadLine());
int count = 1;
int answer = 666;
if (input == 0)
{
    Console.WriteLine(answer);
    return;
}
while (input != count)
{               
    answer++;
    if (answer.ToString().Contains("666"))
    {
        count++;
    }
}
Console.WriteLine(answer);
string[] a = Console.ReadLine().Split();
int K = int.Parse(a[0]);
int N = int.Parse(a[1]);
long[] input = new long[K];

for (int i = 0; i < input.Length; i++)
{
    input[i] = int.Parse(Console.ReadLine());
}

Array.Sort(input);
long left = 1;
long right = input[input.Length - 1];

while (left <= right)
{
    long mid = (left + right) / 2;
    long count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        count += input[i] / mid;
    }
    if (count < N)
    {
        right = mid - 1;
    }
    else
    {
        left = mid + 1;
    }
}
Console.WriteLine(right);
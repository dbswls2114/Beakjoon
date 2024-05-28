using System.Text;
using System.Collections.Generic;

string[] i = Console.ReadLine().Split();
int member = int.Parse(i[0]);
int num = int.Parse(i[1]);
Queue<int> answersq = new Queue<int>();
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("<");
for (int s = 1; s <= member; s++)
{
    answersq.Enqueue(s);

}
int count = 0;
while (answersq.Count > 0)
{
    count++;
    if(count == num)
    {
        stringBuilder.Append(answersq.Dequeue()+", ");
        count = 0;
    }else
    {
        answersq.Enqueue(answersq.Dequeue());
    }
}
stringBuilder.Remove(stringBuilder.Length - 2,2);
stringBuilder.Append(">");
Console.WriteLine(stringBuilder.ToString());
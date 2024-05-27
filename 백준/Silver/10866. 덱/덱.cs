    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    LinkedList<int> list = new LinkedList<int>();
    StringBuilder stringBuilder = new StringBuilder();

    string[] input = new string[int.Parse(Console.ReadLine())];
    for (int i = 0;i < input.Length;i++)
    {
        input[i] = Console.ReadLine();
    }
    foreach (string i in input)
    {
        string[] isplit = i.Split(' ');
        switch (isplit[0])
        {
            case "push_front" :
                list.AddFirst(int.Parse(isplit[1]));
                    break;
            case "push_back":
                list.AddLast(int.Parse(isplit[1]));
                break;
            case "pop_front":
                if(list.Count == 0)
                {
                    stringBuilder.AppendLine($"{-1} ");
                    break;
                }
                stringBuilder.AppendLine($"{list.First.Value} ");
                list.RemoveFirst();
                break;
            case "pop_back":
                if (list.Count == 0)
                {
                    stringBuilder.AppendLine($"{-1} ");
                    break;
                }
                stringBuilder.AppendLine($"{list.Last.Value} ");
                list.RemoveLast();
                break;
            case "size":
                stringBuilder.AppendLine($"{list.Count} ");
                break;
            case "empty":
                if(list.Count == 0)
                {
                    stringBuilder.AppendLine($"{1} ");
                }
                else
                {
                    stringBuilder.AppendLine($"{0} ");
                }
                break;
            case "front":
                if (list.Count == 0)
                {
                    stringBuilder.AppendLine($"{"-1"} ");
                    break;
                }
                stringBuilder.AppendLine($"{list.First.Value} ");
                break;
            case "back":
                if (list.Count == 0)
                {
                    stringBuilder.AppendLine($"{"-1"} ");
                    break;
                }
                stringBuilder.AppendLine($"{list.Last.Value} ");
                break;
        }
        
    }
    Console.WriteLine(stringBuilder.ToString());

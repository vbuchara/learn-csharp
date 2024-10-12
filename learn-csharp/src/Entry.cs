using System;
using LearnCsharp.Exercises;
using LearnCsharp.Learning;

namespace LearnCsharp;

public class Entry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Go to: ");
        Console.WriteLine("1 - Learning");
        Console.WriteLine("2 - Exercises (Iterators)");

        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Program.Entry(args);
                break;
            case "2":
                Iterators.Entry(args);
                break;
            default:
                Console.WriteLine("Unknown option.");
            break;
        }
    }
}

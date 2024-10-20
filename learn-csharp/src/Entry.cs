using System;
using LearnCsharp.Exercises;
using LearnCsharp.Learning;

namespace LearnCsharp;

public class Entry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Go to: ");
        Console.WriteLine("1 - Learning (Program)");
        Console.WriteLine("2 - Exercises (Iterators)");
        Console.WriteLine("3 - Exercises (Files)");

        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Program.Entry(args);
            break;
            case "2":
                Iterators.Entry(args);
            break;
            case "3":
                Files.Entry(args);
            break;
            default:
                Console.WriteLine("Unknown option.");
            break;
        }
    }
}

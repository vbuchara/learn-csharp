using System;
using Humanizer;

namespace LearnCsharp.Learning;

public class Files
{
    public static void Entry(string[] args){
        var exercises = new Dictionary<string, Action>(){
            {"1", Exercise1},
            {"2", Exercise2}
        };

        while(true){
            Console.WriteLine("\nSelect one exercise: ");

            foreach(var exerciseEntry in exercises){
                Console.WriteLine($"{exerciseEntry.Key} - {exerciseEntry.Value.Method.Name.Humanize()}");
            }

            var input = Console.ReadLine();

            if(input == "exit") break;

            if (!string.IsNullOrWhiteSpace(input) && exercises.TryGetValue(input, out Action? Exercise))
            {
                Console.WriteLine();
                Exercise();
            }
        }
    }

    /// <summary>
    /// 1- Write a program that reads a text file and displays the number of words.
    /// </summary>

    public static void Exercise1(){
        Console.Write("Informe the path to a file: ");

        var input = Console.ReadLine();

        try {
            if(string.IsNullOrEmpty(input) || !Path.Exists(input)){
                throw new Exception("File informed not found.");
            }

            var file = File.ReadAllText(input);

            var words = file.Split([' ', ',', '.','\t','\n'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"This file contains {words.Length} words.");
        } catch(Exception exception){
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);
        }
    }

    /// <summary>
    /// 2- Write a program that reads a text file and displays the longest word in the file.
    /// </summary>
    public static void Exercise2(){
        Console.Write("Informe the path to a file: ");

        var input = Console.ReadLine();

        try {
            if(string.IsNullOrEmpty(input) || !Path.Exists(input)){
                throw new Exception("File informed not found.");
            }

            var file = File.ReadAllText(input);

            var words = file.Split([' ', ',', '.','\t','\n'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            var biggestWord = words.Aggregate("", (biggestWord, word) => {
                return word.Length > biggestWord.Length  ? word : biggestWord;
            });

            Console.WriteLine($"The longest word in the file is: {biggestWord}");
        } catch(Exception exception){
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);
        }
    }
}

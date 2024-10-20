using System;
using Humanizer;

namespace LearnCsharp.Exercises;

public class Iterators
{
    public static void Entry(string[] args)
    {
        var input = "";
        var exercises = new Dictionary<string, Action>(){
            {"1", Exercise1},
            {"2", Exercise2},
            {"3", Exercise3},
            {"4", Exercise4},
            {"5", Exercise5}
        };

        do {
            Console.WriteLine("\nSelect one exercise: ");

            foreach(var exerciseEntry in exercises){
                Console.WriteLine($"{exerciseEntry.Key} - {exerciseEntry.Value.Method.Name.Humanize()}");
            }

            input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) && exercises.TryGetValue(input, out Action? Exercise))
            {
                Console.WriteLine();
                Exercise();
            }
        } while(input != "exit");
    }


    /// <summary>
    /// 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    /// Display the count on the console.
    /// </summary>
    public static void Exercise1()
    {
        int divisibleBy3Count = Enumerable.Range(1, 100)
            .ToList()
            .Where((number) => number % 3 == 0)
            .Count();

        Console.WriteLine($"Between 1 and 100, there are {divisibleBy3Count} numbers divisible by 3");
    }

    /// <summary>
    /// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
    /// Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    public static void Exercise2()
    {
        var numbers = new List<int>();

        while(true){
            try {
                Console.Write("Type a number (Or 'ok' to stop): ");
                var input = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(input)) throw new Exception();
                if(input.Equals("ok")) break;

                if(int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                } else {
                    throw new Exception();
                }
            } catch (Exception){
                Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
            }
            
        };

        int sum = numbers.Sum();
        Console.WriteLine($"\nThe sum of all entered numbers is: {sum}");
    }

    /// <summary>
    /// 3- Write a program and ask the user to enter a number. Compute the factorial of the number 
    /// and print it on the console. For example, if the user enters 5, the program 
    /// should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    /// </summary>
    public static void Exercise3(){
        Console.Write("Enter a number: ");
        var input = Console.ReadLine();

        if(int.TryParse(input, out int number)){
            if(number > 12) {
                Console.WriteLine("The factorial is too large to display.");
                return;
            }

            long factorial = Enumerable.Range(1, number)
                .ToList()
                .Aggregate(1, (result, number) => result * number);

            Console.WriteLine($"The factorial of {input} is ");

            return;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    public static void Exercise4(){
        var random = new Random();
        var randomNumber = random.Next(1, 10);
        var attempts = 0;

        while(true) {
            if(attempts >= 4) {
                Console.WriteLine($"\nYou Lost! The number was {randomNumber}");
                break;
            };

            Console.Write("Guess a number between 1 and 10: ");
            var input = Console.ReadLine();

            if(input != null && input.Trim().Equals(randomNumber.ToString())){
                Console.WriteLine($"\nYou Won! The number was {randomNumber}");
                break;
            } else {
                Console.WriteLine("\nWrong! Try again.\n");
            }

            attempts++;
        };
    }

    /// <summary>
    /// 5- Write a program and ask the user to enter a series of numbers separated by comma. 
    /// Find the maximum of the numbers and display it on the console. 
    /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    /// </summary>
    public static void Exercise5(){
        Console.Write("Type a series of numbers separated by comma: ");
        var input = Console.ReadLine();
        string[] stringNumbers = input != null ? input.Split(",") : [];
        int[] numbers = stringNumbers
            .Select<string, int?>((stringNumber) =>  int.TryParse(stringNumber, out int number) ? number : null)
            .OfType<int>()
            .ToArray();
            
        int[] orderedNumbers = numbers.OrderBy((number) => number).ToArray();
        
        Console.WriteLine($"\nThe maximum of the numbers is {orderedNumbers.Last()}");
    }
}

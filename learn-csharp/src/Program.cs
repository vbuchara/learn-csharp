using LearnCsharp.Classes;
using LearnCsharp.Structs;
using Microsoft.VisualBasic;

namespace LearnCsharp;

class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Select a method:");
        Console.WriteLine("1 - CheckedOverflow");
        Console.WriteLine("2 - RealNumbers");
        Console.WriteLine("3 - TextVariables");
        Console.WriteLine("4 - BooleanVariable");
        Console.WriteLine("5 - VarVariable");
        Console.WriteLine("6 - StringPlaceholders");
        Console.WriteLine("7 - Conversions");
        Console.WriteLine("8 - Operators");
        Console.WriteLine("9 - Classes");
        Console.WriteLine("10 - Structs");
        Console.WriteLine("11 - Arrays");
        Console.WriteLine("12 - Strings");

        string? consoleInput = Console.ReadLine();
        
        switch (consoleInput){
            case "1":
                CheckedOverflow();
            break;
            case "2":
                RealNumbers();
            break;
            case "3":
                TextVariables();
            break;
            case "4":
                BooleanVariable();
            break;
            case "5":
                VarVariable();
            break;
            case "6":
                StringPlaceholders();
            break;
            case "7":
                Conversions();
            break;
            case "8":
                Operators();
            break;
            case "9":
                Classes();
            break;
            case "10":
                Structs();
            break;
            case "11":
                Arrays();
            break;
            case "12":
                Strings();
            break;
            default:
                Console.WriteLine("Invalid option.");
            break;
        }
    }

    private static void CheckedOverflow(){
        Console.WriteLine("Enable Checked?");
        string? answerInput = Console.ReadLine();

        Console.WriteLine("\nType a number for a by variable:");

        string? consoleInput = Console.ReadLine();
        byte? byteVariable = consoleInput != null ? byte.Parse(consoleInput) : null;

        if (answerInput == "yes"){
            checked {
                byteVariable = (byte?) (byteVariable + 1);
            }
        } else {
            byteVariable = (byte?) (byteVariable + 1);
        }

        Console.WriteLine("Variable value: " + byteVariable);
    }

    private static void RealNumbers(){
        float floatNumber = 123.456f;
        double doubleNumber = 123.456;
        decimal decimalNumber = 123.456m;

        Console.WriteLine("\nFloat: " + floatNumber);
        Console.WriteLine("Double: " + doubleNumber);
        Console.WriteLine("Decimal: " + decimalNumber);
    }

    private static void TextVariables(){
        // Quotes represent char values
        const char character = 'A';
        // Double quotes represent string values
        const string text = "Abacaxi";

        Console.WriteLine("\nCharacter: " + character);
        Console.WriteLine("Text: " + text);
    }

    private static void BooleanVariable(){
        const bool isJoonPretty = true;

        Console.WriteLine("\nIs Joon Pretty? Yes! So " + isJoonPretty);
    }

    private static void VarVariable(){
        var varStringVariable = "This is a anything variable";
        var varIntVariable = 32;
        var varDoubleVariable = 3.14159;

        Console.WriteLine("\nVar String Variable: " + varStringVariable);
        Console.WriteLine("Type: " + varStringVariable.GetType().Name);

        Console.WriteLine("\nVar Int Variable: " + varIntVariable);
        Console.WriteLine("Type: " + varIntVariable.GetType().Name);

        Console.WriteLine("\nVar Double Variable: " + varDoubleVariable);
        Console.WriteLine("Type: " + varDoubleVariable.GetType().Name);
    }

    private static void StringPlaceholders(){
        string name = "Joon";
        int age = 25;
        string adjective = "hot";

        Console.WriteLine("\nBeautiful {0} is {1} and {2}!!", name, age, adjective);
    }

    private static void Conversions(){
        // Implicit conversion
        int intNumber = 123;
        float floatNumber = intNumber;

        Console.WriteLine($"\nIntNumber: {intNumber} of type {intNumber.GetType().Name}");
        Console.WriteLine($"FloatNumber: {floatNumber} of type {floatNumber.GetType().Name}");

        // Explicit conversion
        double doubleNumber = 123.0;
        int anotherIntNumber = (int) doubleNumber;

        Console.WriteLine($"\nDoubleNumber: {doubleNumber} of type {doubleNumber.GetType().Name}");
        Console.WriteLine($"IntegerNumber: {anotherIntNumber} of type {anotherIntNumber.GetType().Name}");

        // Non-compatible conversion
        string stringNumber = "123";

        int firstConversion = Convert.ToInt32(stringNumber);
        int secondConversion = int.Parse(stringNumber);

        Console.WriteLine($"\nStringNumber: {stringNumber} of type {stringNumber.GetType().Name}");
        Console.WriteLine($"FirstConversion: {firstConversion} of type {firstConversion.GetType().Name}");
        Console.WriteLine($"SecondConversion: {secondConversion} of type {secondConversion.GetType().Name}");
    }

    private static void Operators(){
        int firstVariable = 10;
        // Assigns the current values of firstVariable (10) to secondVariable and
        // then increment firstVariable by one
        int secondVariable = firstVariable++;

        Console.WriteLine($"\nFirst Variable: {firstVariable}");
        Console.WriteLine($"Second Variable: {secondVariable}");
    }

    private static void Classes(){
        Person person = new Person("Joon", "Yorigami");
        person.Introduce();

        Calculator calculator = new Calculator();
        int result = calculator.Add(2, 2);

        Console.WriteLine($"\nResult: {result}");
    }

    private static void Structs(){
        // Structs are similar to classes, but they allocate value, instead of references.
        // Have better performance overall, if used in short lived instances
        RgbColor rgb = new RgbColor { Red = 20, Green = 0, Blue = 63 };

        Console.WriteLine($"\nRGB Color: ({rgb.Red}, {rgb.Green}, {rgb.Blue})");
    }

    private static void Arrays(){
        // By default, array values are set to the default of that type (0 in this case)
        int[] numbers = new int[4];

        numbers[1] = 1;
        numbers[2] = 2;
        numbers[3] = 3;

        Console.Write("\n");
        numbers.ToList().ForEach(number => Console.WriteLine($"Number: {number}"));

        // Initialization
        int[] moreNumbers = [4, 5, 6];

        Console.Write("\n");
        moreNumbers.ToList().ForEach(number => Console.WriteLine($"Number: {number}"));

        // Another form of initialization
        string[] names = new string[3] {"Joon", "Eirin", "Kaguya"};

        Console.Write("\n");
        names.ToList().ForEach(name => Console.WriteLine($"Name: {name}"));
    }

    private static void Strings(){
        string[] characters = ["Eirin", "Kaguya"];

        Console.WriteLine($"\n{string.Join(" loves ", characters)}");
        
        // Verbatim string
        string somePath = @"c:\some\path";

        Console.WriteLine($"\nSome Path: {somePath}");        
    }
}
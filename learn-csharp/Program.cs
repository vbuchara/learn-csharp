
using System.Runtime.InteropServices;

namespace LearnCsharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Select a method:");
            Console.WriteLine("1 - CheckedOverflow");
            Console.WriteLine("2 - RealNumbers");
            Console.WriteLine("3 - TextVariables");
            Console.WriteLine("4 - BooleanVariable");
            Console.WriteLine("5 - VarVariable");
            Console.WriteLine("6 - StringPlaceholders");
            Console.WriteLine("7 - Conversions");

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
                default:
                    Console.WriteLine("Invalid option.");
                break;
            }
        }

        static void CheckedOverflow(){
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

        static void RealNumbers(){
            float floatNumber = 123.456f;
            double doubleNumber = 123.456;
            decimal decimalNumber = 123.456m;

            Console.WriteLine("\nFloat: " + floatNumber);
            Console.WriteLine("Double: " + doubleNumber);
            Console.WriteLine("Decimal: " + decimalNumber);
        }

        static void TextVariables(){
            // Quotes represent char values
            const char character = 'A';
            // Double quotes represent string values
            const string text = "Abacaxi";

            Console.WriteLine("\nCharacter: " + character);
            Console.WriteLine("Text: " + text);
        }

        static void BooleanVariable(){
            const bool isJoonPretty = true;

            Console.WriteLine("\nIs Joon Pretty? Yes! So " + isJoonPretty);
        }

        static void VarVariable(){
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

        static void StringPlaceholders(){
            string name = "Joon";
            int age = 25;
            string adjective = "hot";

            Console.WriteLine("\nBeautiful {0} is {1} and {2}!!", name, age, adjective);
        }

        static void Conversions(){
            // Implicit conversion
            int intNumber = 123;
            float floatNumber = intNumber;

            Console.WriteLine($"\nIntNumber: {intNumber} of type {intNumber.GetType().Name}");
            Console.WriteLine($"FloatNumber: {floatNumber} of type {floatNumber.GetType().Name}");
        }
    }

}
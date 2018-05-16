using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in the operation!");
            string yourInput = Console.ReadLine;
            Console.WriteLine(Calculate(yourInput));
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
        }
        static string Calculate(string yourInput)
        {
            string[] splitInput = yourInput.Split(' ');
            // most meghatározzuk az operandot és a két operátort
            string myOperator = splitInput[0];
            double firstNumber = Convert.ToInt32(splitInput[1]);
            double secondNumber = Convert.ToInt32(splitInput[2]);

            if (myOperator == "+")
            {
                int mySolution = firstNumber + secondNumber;
                return "Your solution is " + mySolution;
            }
            else if (myOperator == "-")
            {
                int mySolution = firstNumber - secondNumber;
                return "Your solution is: " + mySolution;
            }
            else if (myOperator == "*")
            {
                int mySolution = firstNumber * secondNumber;
                return "Your solution is: " + mySolution;
            }
            else if (myOperator == "/")
            {
                int mySolution = firstNumber / secondNumber;
                return "Your solution is: " + mySolution;
            }
            else if (myOperator == "%")
            {
                int mySolution = firstNumber % secondNumber;
                return "Your solution is: " + mySolution;
            }
        }
    }
}
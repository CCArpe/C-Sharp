using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean status = true;
            int answer = 0;

            while (status == true) {
            Console.WriteLine("What type of operation would you like to do? Type add, subtract, multiply, or divide.");
            String response = Console.ReadLine();
            Console.WriteLine("Enter first number.");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if (response == "addition" || response == ("add") || response == ("+")) {
                answer = firstNum + secondNum;
            }

            else if (response == "subtraction" || response == ("subtract") || response == ("-")){
                answer = firstNum - secondNum;
            }

            else if (response == "multiplication" || response == ("multiply") || response == ("*")) {
                answer = firstNum * secondNum;
            }

            else if (response == "division" || response == ("divide") || response == ("/")){
                answer = firstNum / secondNum;
            }


            Console.WriteLine("The answer is " + answer);
            Console.WriteLine("Enter 1 to quit. Enter 2 for another operation.");
            String input = Console.ReadLine();
            if (input == "1") {
                Console.WriteLine("Goodbye!");
                status = false;
            }
            else if (input == "2"){
                status = true;
            }
            }
        }
    }
}

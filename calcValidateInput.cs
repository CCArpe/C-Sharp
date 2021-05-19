using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean status = true;
            int answer = 0;
            int firstNum = 0;
            int secondNum = 0;

            while (status == true) {
            Console.WriteLine("What type of operation would you like to do? Type add, subtract, multiply, or divide.");
            String response = Console.ReadLine();
        
            if (response == ("add")) {
                Console.WriteLine("Enter first number.");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number.");
                secondNum = Convert.ToInt32(Console.ReadLine());
                answer = firstNum + secondNum;
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

            else if (response == ("subtract")){
                Console.WriteLine("Enter first number.");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number.");
                secondNum = Convert.ToInt32(Console.ReadLine());
                answer = firstNum - secondNum;
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

            else if (response == ("multiply")) {
                Console.WriteLine("Enter first number.");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number.");
                secondNum = Convert.ToInt32(Console.ReadLine());
                answer = firstNum * secondNum;
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

            else if (response == ("divide")){
                Console.WriteLine("Enter first number.");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number.");
                secondNum = Convert.ToInt32(Console.ReadLine());
                answer = firstNum / secondNum;
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
            else {
                Console.WriteLine("Invalid input, please enter again!");
            }


            
            }
        }
    }
}

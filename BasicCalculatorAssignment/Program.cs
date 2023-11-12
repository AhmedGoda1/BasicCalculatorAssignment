namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int userChoice = Convert.ToInt32(Console.ReadLine());

                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (userChoice == 5) 
                {
                    break;
                }
                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                // Task 5. Create double variable for default result value and assign it to be 0
                double defaultResult;
                // Task 6. Handle choices using switch statement
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("The result is " + addMethod(firstNumber, secondNumber));
                        break;

                    case 2:
                        Console.WriteLine("The result is " + subtractMethod(firstNumber, secondNumber));
                        break;

                    case 3:
                        Console.WriteLine("The result is " + mutiplyMethod( firstNumber, secondNumber));
                        break;

                    case 4:
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("You cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine("The result is " + divisionMethod(firstNumber, secondNumber));
                            
                        }
                        break;
                        
                }
                // Task 6.1 For each case create new function/method an call it inside the case


                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods
                //          - Case 1: Add 
               

                // Task 7. Print out the result
            }
        }

        // Declare your methods/functions here
        static double addMethod(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        //          - Case 2: Subtract
        static double subtractMethod(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        //          - Case 3: Multiply
        static double mutiplyMethod(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        //          - Case 4: Divide, Note remeber to handle 0
        static double divisionMethod(double firstNumber, double secondNumber)
        {

            return firstNumber / secondNumber;

        }
    }
}
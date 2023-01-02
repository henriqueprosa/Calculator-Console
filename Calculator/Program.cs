using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation = 0;

            while (operation != 5)
            {
                Console.WriteLine("What operation do you want to do?");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Exit \n");

                operation = int.Parse(Console.ReadLine());

                while (operation < 1 || operation > 5)
                {
                    Console.WriteLine("\nWarning: Select other valid option!\n");
                    Console.WriteLine("What operation do you want to do?");
                    Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtraction");
                    Console.WriteLine("3 - Multiplication");
                    Console.WriteLine("4 - Division");
                    Console.WriteLine("5 - Exit \n");
                    operation = int.Parse(Console.ReadLine());
                }
                Double result = 0;
                switch (operation)
                {
                    case 1:
                        {
                            result = Addition(FirstNumber(), SecondNumber());
                            PrintResult(result);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(FirstNumber(), SecondNumber());
                            PrintResult(result);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(FirstNumber(), SecondNumber());
                            PrintResult(result);
                            break;
                        }
                    case 4:
                        {
                            result = 3;
                            PrintResult(Division(FirstNumber(), SecondNumber()));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nThe program will be closed.");
                            break;
                        }
                }
            }          
                  
        }
  
        public static Double Addition(Double firstNumber, Double secondNumber)
        {
           return (firstNumber + secondNumber);
        } 
        public static Double Subtraction(Double firstNumber, Double secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        public static Double Multiplication(Double firstNumber, Double secondNumber)
        {
            return (firstNumber * secondNumber);
        }
        public static Double Division(Double firstNumber, Double secondNumber)
        {
            while(secondNumber == 0)
            {
                Console.WriteLine("\nWarning: Do not exist division for zero!\n");
                secondNumber = SecondNumber();
            }
            return (firstNumber / secondNumber);
        }
        public static Double FirstNumber()
        {
            Console.WriteLine("Enter the first number: ");
            Double firstNumberInput = Double.Parse(Console.ReadLine());
            return firstNumberInput;
        }
        public static Double SecondNumber()
        {
            Console.WriteLine("Enter the second number: ");
            Double secondNumberInput = Double.Parse(Console.ReadLine());
            return secondNumberInput;
        }
        public static void PrintResult(Double result)
        {
            Console.WriteLine("\nThe operation result is: {0}\n", result);
        }

    }
}
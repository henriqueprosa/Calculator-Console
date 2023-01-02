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
            Console.WriteLine("What operation do you want to do?");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division \n");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int result;

            switch (operation)
            {
                case 1:
                    {
                        result = Addition(firstNumber, secondNumber);
                        break;
                    }
            }


        }
        public static int Addition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

    }
}
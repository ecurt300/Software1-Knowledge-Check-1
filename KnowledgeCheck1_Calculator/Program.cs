using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{


   
    class Program
    {

        static void GetSubtraction()
        {
            var subtractNumber1 = Console.ReadLine();
            var subtractNumber2 = Console.ReadLine();

            if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
            {
                Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                Console.Write(Calculator.Subtract(subNumOne, subNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }

        static void GetAddition()
        {
            var addNumber1 = Console.ReadLine();
            var addNumber2 = Console.ReadLine();

            if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
            {
                Console.Write($"{addNumber1} + {addNumber2} = ");
                Console.Write(Calculator.Add(addNumOne, addNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
        static void GetDivision()
        {

            var divideNumber1 = Console.ReadLine();
            var divideNumber2 = Console.ReadLine();

            if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
            {
                Console.Write($"{divideNumber1} / {divideNumber2} = ");
                Console.Write(Calculator.Divide(divNumOne, divNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
         
        }
        static void GetMultiplication()
        {
            Console.WriteLine("Enter number 1 to multiply");
            var multiplierNumber1 = Console.ReadLine();
            Console.WriteLine("Enter number 2 to multiply");
            var multiplierNumber2 = Console.ReadLine();

            if (int.TryParse(multiplierNumber1, out int multiNumOne) && int.TryParse(multiplierNumber2, out int multiNumTwo))
            {
                Console.Write($"{multiplierNumber1} * {multiplierNumber2} = ");
                Console.Write(Calculator.Multiply(multiNumOne, multiNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            

            var input = Console.ReadLine();

            //Calculator should not be instanced once it is static
            // var calculator = new Calculator();
            while (input != null && input.ToLower().Trim() != "exit")
            {
                
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        GetAddition();
                        
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        GetSubtraction();
                        break;

                    case "3":
                        // Add code here
                        Console.WriteLine("Enter 2 integers to multiply");
                        GetMultiplication();
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        GetDivision();
                        break;


                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
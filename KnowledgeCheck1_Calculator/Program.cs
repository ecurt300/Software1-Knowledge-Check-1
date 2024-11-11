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
            Console.WriteLine("Enter number 1 to subtract");
            var subtractNumber1 = Console.ReadLine();
            Console.WriteLine("Enter number 2 to subtract");
            var subtractNumber2 = Console.ReadLine();

           
            Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
            Console.Write(Calculator.Subtract(subtractNumber1, subtractNumber2));
            
           
           
            
        }

        static void GetAddition()
        {
            Console.WriteLine("Enter number 1 to addition");
            var addNumber1 = Console.ReadLine();
            Console.WriteLine("Enter number 2 to addition");
            var addNumber2 = Console.ReadLine();


            Console.Write($"{addNumber1} + {addNumber2} = ");
            Console.Write(Calculator.Add(addNumber1, addNumber1));
        }
        static void GetDivision()
        {
            Console.WriteLine("Enter number 1 to division");
            var divideNumber1 = Console.ReadLine();
            Console.WriteLine("Enter number 2 to division");
            var divideNumber2 = Console.ReadLine();

            Console.Write($"{divideNumber1} + {divideNumber2} = ");
            Console.Write(Calculator.Divide(divideNumber1, divideNumber2));

        }
        static void GetMultiplication()
        {
            Console.WriteLine("Enter number 1 to multiply");
            var multiplierNumber1 = Console.ReadLine();
            Console.WriteLine("Enter number 2 to multiply");
            var multiplierNumber2 = Console.ReadLine();

            Console.Write($"{multiplierNumber1} + {multiplierNumber1} = ");
            Console.Write(Calculator.Multiply(multiplierNumber1, multiplierNumber2));
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division, enter exit to exit program");

            

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
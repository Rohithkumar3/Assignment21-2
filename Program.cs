using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21_2
{
   public delegate T Operation<T>(T a, T b);
        public class Program
        {
            static T Add<T>(T a, T b) => (dynamic)a + b;
            static T Sub<T>(T a, T b) => (dynamic)a - b;
            static T Multi<T>(T a, T b) => (dynamic)a * b;
        static T Div<T>(T a, T b)
        {
            if (b.Equals((dynamic)0))
            {
                Console.WriteLine("cannot divide by zero. Returning default value");
                return default(T);
            }
            else
                return (dynamic)a / b;
        }
            static void Main(string[] args)
            {
                Operation<double> add =Add;
                Operation<double> sub = Sub;
                Operation<double> multi = Multi;
                Operation<double> div = Div;
                Console.WriteLine("Enter First Number");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose an Operation \n1.Addition \n2.Subtraction\n3.Multiplication. \n4.Division");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Addition of {num1} and {num2} is " + add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine($"Subtraction of {num1} and {num2} is " + sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication of {num1} and {num2} is " + multi(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine($"Division of {num1} and {num2} is " + div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("invalid operation !!!");
                        break;
                }
                Console.ReadKey();

            }
        }

    }
    


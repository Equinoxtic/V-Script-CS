using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class Calc
    {
        public void OpenApp()
        {
            int a;
            int b;
            string curOper;

            Console.WriteLine("Input the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First number: " + a + "\n");

            Console.WriteLine("Input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: " + b + "\n");

            Console.WriteLine("Select an Operation: \nAddition\nSubtraction\nMultiplication\nDivision");
            curOper = Console.ReadLine();

            switch (curOper)
            {
                case "Addition":
                    Console.WriteLine(a + b);
                    break;

                case "Subtraction":
                    Console.WriteLine(a - b);
                    break;

                case "Multiplication":
                    Console.WriteLine(a * b);
                    break;

                case "Division":
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }

    class Math
    {
        public int res;
        public int a;
        public int b;

        public void InitNums()
        {
            Console.Write("Input your first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your second number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void Add()
        {
            res = a + b;
        }

        public void Sub()
        {
            res = a - b;
        }

        public void Multiply()
        {
            res = a * b;
        }

        public void Divide()
        {
            res = a / b;
        }
    }
}

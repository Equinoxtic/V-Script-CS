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
}

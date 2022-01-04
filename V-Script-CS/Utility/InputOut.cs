using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.Utility
{
    class InputOut
    {
        public void InputStr(string str)
        {
            Console.Write("Input some text for your string: ");
            str = Console.ReadLine();
            Console.WriteLine("String: " + str);
        }

        public void InputInt(int num)
        {
            Console.Write("Input a number for your integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer: " + num);
        }

        public void InputFloat(float num)
        {
            Console.Write("Input some numbers for your float: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Float: " + num);
        }
    }
}

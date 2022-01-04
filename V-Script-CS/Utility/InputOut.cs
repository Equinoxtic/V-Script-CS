using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.Utility
{
    class InputOut
    {
        public void InputStr()
        {
            var str = "";
            Console.Write("Input some text for your string: ");
            str = Console.ReadLine();
            Console.WriteLine("String: " + str);
        }

        public void InputInt()
        {
            var num = 0;
            Console.Write("Input a number for your integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer: " + num);
        }

        public void InputFloat()
        {
            var num = 0;
            Console.Write("Input some numbers for your float: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Float: " + num);
        }
    }
}

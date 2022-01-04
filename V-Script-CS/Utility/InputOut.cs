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
            Console.Write("Input some string: ");
            str = Console.ReadLine();
            Console.WriteLine("String: " + str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS_VS_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var curAction = 0;

            States.InputOutSelectorState IOSelector = new States.InputOutSelectorState();

            Console.WriteLine("===== V-Script =====\n");
            Console.Write("Select an Action:\n[1] Basic Input\n");
            curAction = Convert.ToInt32(Console.ReadLine());

            switch (curAction)
            {
                case 1:
                    IOSelector.IOSelection();
                    break;
            }
        }
    }
}
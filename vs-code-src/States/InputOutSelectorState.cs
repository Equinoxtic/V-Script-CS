using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS_VS_Code.States
{
    class InputOutSelectorState
    {
        public void IOSelection()
        {
            var curAction = "";

            Utility.InputOut IO = new Utility.InputOut();

            Console.WriteLine("===== Input Selection =====\n");
            Console.Write("Select an Action:\n[str] Input String | [int] Input Integer | [float] Input Float\n");
            curAction = Console.ReadLine();

            switch (curAction)
            {
                case "str":
                    IO.InputStr();
                    break;

                case "int":
                    IO.InputInt();
                    break;

                case "float":
                    IO.InputFloat();
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.States
{
    class LoopSelectionState
    {
        public void LoopSelector()
        {
            string curSelected;
            Utility.Loops LocalLoops = new Utility.Loops();
            Console.WriteLine("Select a loop: ");
            Console.Write("[vF] For Loop | [vW] While Loop\n");
            curSelected = Console.ReadLine();

            switch (curSelected)
            {
                case "vF":
                    LocalLoops.VFor();
                    break;

                case "vW":
                    LocalLoops.VWhile();
                    break;
            }
        }
    }
}
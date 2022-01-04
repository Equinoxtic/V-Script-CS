using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.States
{
    class MathSelectionState
    {
        public bool IsInited = false;
        public void MathSelector()
        {
            var curSelected = 0;
            Math VMath = new Math();

            Console.WriteLine("Select a function: ");
            Console.Write("[1] Add\n[2] Sub\n[3] Multiply\n[4] Divide\n");
            curSelected = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYou'll have to initialize some numbers first!\n");

            VMath.InitNums();

            switch (curSelected)
            {
                case 1:
                    VMath.Add();
                    break;

                case 2:
                    VMath.Sub();
                    break;

                case 3:
                    VMath.Multiply();
                    break;

                case 4:
                    VMath.Divide();
                    break;
            }
            Console.WriteLine(VMath.res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.States
{
    class CalculateClassState
    {
        public void CalcStateSelector()
        {
            int curSelected;

            Calculate Calculator = new Calculate();
            Math VMath = new Math();
            States.MathSelectionState MathSelectState = new States.MathSelectionState();

            Console.WriteLine("Select a function / class: ");
            Console.Write("[1] Open Calculator (Function) | [2] Math (Class)\n");
            curSelected = Convert.ToInt32(Console.ReadLine());

            switch (curSelected)
            {
                case 1:
                    Calculator.OpenApp();
                    break;

                case 2:
                    MathSelectState.MathSelector();
                    break;
            }
        }
    }
}

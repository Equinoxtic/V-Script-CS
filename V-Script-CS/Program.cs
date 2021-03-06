using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int actionType;

            States.CalculateClassState CalculateState = new States.CalculateClassState();
            States.LoopSelectionState SelectLoopState = new States.LoopSelectionState();
            States.CreatorClassState CreateState = new States.CreatorClassState();
            States.InputOutSelector IOState = new States.InputOutSelector();
            States.LocalObjsSelectState LObjsSelect = new States.LocalObjsSelectState();

            Console.WriteLine("===== V-Script ======\n");
            Console.WriteLine("Select an action: ");
            Console.Write("[1] Calculate | [2] Loops | [3] Object Creator | [4] Basic Input | [5] Object Selection\n");
            actionType = Convert.ToInt32(Console.ReadLine());

            switch (actionType)
            {
                case 1:
                    CalculateState.CalcStateSelector();
                    break;

                case 2:
                    SelectLoopState.LoopSelector();
                    break;

                case 3:
                    CreateState.CreatorSelector();
                    break;

                case 4:
                    IOState.IOSelect();
                    break;

                case 5:
                    LObjsSelect.LObjsSelection();
                    break;
            }
        }
    }
}

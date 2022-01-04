using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.States
{
    class CreatorClassState
    {
        public void CreatorSelector()
        {
            var curSelected = "";
            Utility.ObjectCreator Create = new Utility.ObjectCreator();
            Console.WriteLine("Select an Action: ");
            Console.Write("[obj] Create an Object | [func] Create a Function | [class] Create a Class\n");
            curSelected = Console.ReadLine();

            switch (curSelected)
            {
                case "obj":
                    Create.Object();
                    break;

                case "func":
                    Create.CustomFunction();
                    break;

                case "class":
                    Create.CustomClass();
                    break;
            }
        }
    }
}

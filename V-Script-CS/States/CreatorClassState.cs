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
            ObjectCreator Create = new ObjectCreator();
            Console.WriteLine("Select an Action: ");
            Console.Write("[obj] Create an Object\n");
            curSelected = Console.ReadLine();

            switch (curSelected)
            {
                case "obj":
                    Create.Object();
                    break;
            }
        }
    }
}

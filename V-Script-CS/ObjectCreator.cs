using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class ObjectCreator
    {
        public void Object()
        {
            var objName = "";
            var objType = "";
            var strObjType = "";
            var objStr = "";
            var objInt = 0;
            var objFloat = 0;

            Console.WriteLine("===== Object Builder =====\n");
            Console.Write("Input a name for your Object: ");
            objName = Console.ReadLine();

            Console.WriteLine("Select a type for your Object: ");
            Console.Write("(str) String\n(int) Integer\n(float) Float\n");
            objType = Console.ReadLine();

            switch (objType)
            {
                case "str":
                    strObjType = "string";
                    InputStr(objStr);
                    break;

                case "int":
                    strObjType = "integer";
                    InputInt(objInt);
                    break;

                case "float":
                    strObjType = "float";
                    InputFloat(objFloat);
                    break;
            }
            OutputDetails(objName, objType, objStr, objInt, objFloat, strObjType);
        }
        
        void InputStr(string objectStr)
        {
            Console.Write("Input a string for your Object: ");
            objectStr = Console.ReadLine();
        }

        void InputInt(int objectInt)
        {
            Console.Write("Input a number for your object: ");
            objectInt = Convert.ToInt32(Console.ReadLine());
        }

        void InputFloat(float objectFloat)
        {
            Console.Write("Input a number for your object: ");
            objectFloat = Convert.ToInt32(Console.ReadLine());
        }

        void OutputDetails(string objectName, string objectType, string sObjStr, int sObjInt, float sObjFloat, string objTypeThing)
        {
            Console.WriteLine("Name: " + objectName);
            Console.WriteLine("Type: " + objectType);

            switch (objTypeThing)
            {
                case "string":
                    Console.WriteLine("String: " + sObjStr);
                    break;

                case "integer":
                    Console.WriteLine("Integer: " + sObjInt);
                    break;

                case "float":
                    Console.WriteLine("Float: " + sObjFloat);
                    break;
            }
        }
    }
}

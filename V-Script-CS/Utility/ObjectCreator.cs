using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class ObjectCreator
    {
        public bool isString = false;
        public bool isInt = false;
        public void Object()
        {
            var objName = "";
            var objType = "";
            var strObjType = "";
            var objStr = "";
            var objInt = 0;
            var objFloat = 0;
            var isArray = false;
            var arrLength = 0;
            var arrName = "";

            Console.WriteLine("===== Object Builder =====\n");
            Console.Write("Input a name for your Object: ");
            objName = Console.ReadLine();

            Console.WriteLine("Select a type for your Object: ");
            Console.Write("[str] String | [int] Integer | [float] Float [array] Array\n");
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

                case "array":
                    strObjType = "array";
                    isArray = true;
                    break;
            }

            if (isArray)
            {
                Console.Write("Input the name for your array: ");
                arrName = Console.ReadLine();
                Console.Write("Input the length for your array: ");
                arrLength = Convert.ToInt32(Console.ReadLine());
                string[] arrList = new string[arrLength];
                for (int i = 0; i < arrList.Length; i++)
                {
                    arrList[i] = Console.ReadLine();
                }
                Console.Write("Array Objects:\n");
                for (int i = 0; i < arrList.Length; i++)
                {
                    Console.Write(arrList[i] + " ");
                }
            }
            else
            {
                OutputDetails(objName, objType, objStr, objInt, objFloat, strObjType);
            }
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

        public void CustomFunction()
        {
            var funcName = "";
            var codeBlockType = "";
            var outStr = "";
            var outInt = 0;
            var argLength = 0;
            var options = "";
            var includesArgs = false;

            Console.WriteLine("===== Function Builder ======\n");
            Console.Write("Input a name for your Function: ");
            funcName = Console.ReadLine();

            Console.WriteLine("Select a preset Code Block: ");
            Console.Write("[cbStr] Output String | [cbInt] Output Integer\n");
            codeBlockType = Console.ReadLine();

            Console.Write("Includes arguments? [y/n]: ");
            options = Console.ReadLine();

            if (options == "y") {
                includesArgs = true;
            } else if (options == "n") {
                includesArgs = false;
            } else {
                Console.WriteLine("Unknown Character.");
            }

            switch (codeBlockType)
            {
                case "cbStr":
                    Console.Write("Input some string: ");
                    outStr = Console.ReadLine();
                    Console.WriteLine("String: " + outStr);
                    break;

                case "cbInt":
                    Console.Write("Input a number: ");
                    outInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Integer: " + outInt);
                    break;
            }

            if (includesArgs)
            {
                Console.Write("Input the amount of arguments: ");
                argLength = Convert.ToInt32(Console.ReadLine());
                string[] argList = new string[argLength];
                Console.WriteLine("Input the arguments:\n");
                for (int i = 0; i < argList.Length; i++)
                {
                    argList[i] = Console.ReadLine();
                }
                Console.WriteLine("Function arguments:\n");
                for (int i = 0; i < argList.Length; i++)
                {
                    Console.WriteLine(argList[i]);
                }
            }
            outputFunctionDetails(funcName, options, codeBlockType);
        }

        void outputFunctionDetails(string sFuncName, string sIncArgs, string sCodeBlockType)
        {
            Console.Write("Function name: " + sFuncName + "\nIncludes arguments: " + sIncArgs + "\nCode Block Preset: " + sCodeBlockType);
        }

        public void CustomClass()
        {
            var className = "";
            var constrName = "";
            var options = "";
            var hasConstructor = false;
            var constLength = 1;

            Console.WriteLine("===== Class Builder =====\n");
            Console.Write("Input a name for your Class: ");
            className = Console.ReadLine();

            Console.Write("Include constructor? [y/n]: ");
            options = Console.ReadLine();

            if (options == "y") {
                hasConstructor = true;
            }
            else if (options == "n") {
                hasConstructor = false;
            } else {
                Console.WriteLine("Unknown Character.");
            }

            if (hasConstructor)
            {
                Console.Write("Input the name for your Constructor: ");
                constrName = Console.ReadLine();
                Console.Write("Input a length for your Constructor: ");
                constLength = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Objects for your Constructor:\n");
                string[] constList = new string[constLength];
                for (int i = 0; i < constList.Length; i++)
                {
                    constList[i] = Console.ReadLine();
                }
                Console.WriteLine("Class: " + className + "() {...}\nIncludes Constructor: " + options + "\nConstructor Name: " + constrName + "\nConstructor Length: " + constLength + "\nConstructor Objects:");
                for (int i = 0; i < constList.Length; i++)
                {
                    Console.WriteLine(constList[i]);
                }
            }
            else
            {
                Console.WriteLine("Class: " + className + "() {...}\nIncludes Constructor: " + options);
            }
        }
    }
}
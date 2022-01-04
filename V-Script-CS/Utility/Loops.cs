using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class Loops
    {
        public void VFor()
        {
            var ivar = 0;
            var a = 0;
            var b = 0;
            var cont = "";
            var br = "";

            Console.WriteLine("===== For Loop Builder =====\n");

            Console.WriteLine("for (int i = ivar; i < a; i++) {...}\n");
            Console.Write("Input the integer for 'ivar': ");
            ivar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("for (int i = " + ivar + "; i < a; i++) {...}\n");
            Console.Write("Input the integer for 'a': ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("for (int i = " + ivar + "; i < " + a + "; i++) {...}\n");

            Console.Write("Set Break On or Off? [On/Off]: ");
            br = Console.ReadLine();

            Console.Write("Set Continue On or Off? [On/Off]: ");
            cont = Console.ReadLine();

            if (br == "On" || cont == "On")
            {
                Console.WriteLine("if (" + ivar + " == b) {...}");
                Console.Write("Input the integer for 'b': ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Unknown String.");
            }

            for (int i = ivar; i < a; i++)
            {
                Console.WriteLine(i);
                if (br == "On" && i == b)
                {
                    break;
                }

                if (cont == "On" && i == b)
                {
                    continue;
                }
            }
        }

        public void VWhile()
        {
            var i = 0;
            var ivar = 0;
            var a = 0;
            var b = 0;
            var usesNorm = false;
            var usesDo = false;
            var br = false;
            var cont = false;
            var opts = 0;
            var opts2 = "";
            var setStuff = false;
            var strOpts = "";
            var strOpts2 = "";

            Console.WriteLine("===== While Loop Builder =====\n");

            Console.WriteLine("Select a While Loop method: ");
            Console.Write("\n[1] Normal While\n[2] Do While\n");
            opts = Convert.ToInt32(Console.ReadLine());

            switch (opts)
            {
                case 1:
                    usesNorm = true;
                    break;

                case 2:
                    usesDo = true;
                    break;
            }

            Console.WriteLine("\ni = ivar;");
            Console.Write("Input the value for 'ivar': ");
            ivar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("while (i < a) {...}");
            Console.Write("Input the value for 'a': ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set Break / Continue syntax and an extra statement? [y/n]: ");
            opts2 = Console.ReadLine();

            if (opts2 == "y") {
                setStuff = true;
            } else if (opts2 == "n") {
                setStuff = false;
            } else {
                Console.WriteLine("Unknown Character.");
            }

            if (setStuff)
            {
                InputShit(strOpts, strOpts2, br, cont, b);
            }

            i = ivar;

            if (usesNorm)
            {
                while (i < a)
                {
                    i++;
                    Console.WriteLine(i);
                    if (i == b && br)
                    {
                        break;
                    }

                    else if (i == b && cont)
                    {
                        continue;
                    }
                }
            }

            if (usesDo)
            {
                do
                {
                    i++;
                    Console.WriteLine(i);
                    if (br && i == b)
                    {
                        break;
                    }

                    else if (cont && i == b)
                    {
                        continue;
                    }
                }
                while (i < a);
            }
        }

        void InputShit(string options, string options2, bool cond, bool cond2, int localB)
        {
            Console.Write("Set Break Syntax as [t/f]: ");
            options = Console.ReadLine();

            if (options == "t") {
                cond = true;
            } else if (options2 == "f") {
                cond = false;
            } else {
                Console.WriteLine("Unknown Character.");
            }

            Console.Write("Set Continue Syntax as [t/f]: ");
            options2 = Console.ReadLine();

            if (options2 == "t") {
                cond2 = true;
            } else if (options2 == "f") {
                cond2 = false;
            } else {
                Console.WriteLine("Unknown Character.");
            }

            if (cond || cond2)
            {
                Console.WriteLine("if (i == b) {...}");
                localB = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
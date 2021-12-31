using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS
{
    class VLoops
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

            switch (opts2)
            {
                case "y":
                    setStuff = true;
                    break;

                case "n":
                    setStuff = false;
                    break;
            }

            if (opts2 != "y" || opts2 != "n")
            {
                Console.WriteLine("Unkown Character.");
            }

            if (setStuff == true)
            {
                InputShit(strOpts, strOpts2, br, cont, b);
            }

            i = ivar;

            if (usesNorm == true)
            {
                while (i < a)
                {
                    i++;
                    Console.WriteLine(i);
                    if (i == b && br == true)
                    {
                        break;
                    }

                    else if (i == b && cont == true)
                    {
                        continue;
                    }
                }
            }

            if (usesDo == true)
            {
                do
                {
                    i++;
                    Console.WriteLine(i);
                    if (br == true && i == b)
                    {
                        break;
                    }

                    else if (cont == true && i == b)
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

            switch (options)
            {
                case "t":
                    cond = true;
                    break;

                case "f":
                    cond = false;
                    break;
            }

            if (options != "t" || options != "f")
            {
                Console.WriteLine("Unknown Character.");
                Console.ReadKey();
            }

            Console.Write("Set Continue Syntax as [t/f]: ");
            options2 = Console.ReadLine();

            switch (options2)
            {
                case "t":
                    cond2 = true;
                    break;

                case "f":
                    cond2 = false;
                    break;
            }

            if (options2 != "t" || options2 != "f")
            {
                Console.WriteLine("Unknown Character.");
                Console.ReadKey();
            }

            if (cond == true || cond2 == true)
            {
                Console.WriteLine("if (i == b) {...}");
                localB = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
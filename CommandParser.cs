using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeFancySequence
{
    public class CodeGen
    {
        public void Generate(string[] commands, int[] args)
        {
            if (commands.Length != args.Length)
                throw new ArgumentException(nameof(args));

            var varname = "fancy";

            for (int i = 0; i < commands.Length; i++)
            {
                var command = commands[i];
                switch (command.Trim().ToLower())
                {
                    case "fancy":
                        Console.WriteLine($"var {varname}=new Fancy();");
                        break;

                    case "append":
                        Console.WriteLine($"{varname}.Append({args[i]});");
                        break;

                    case "addall":
                        Console.WriteLine($"{varname}.AddAll({args[i]});");
                        break;

                    case "multall":
                        Console.WriteLine($"{varname}.MultAll({args[i]});");
                        break;

                    case "getindex":
                        Console.WriteLine($"{varname}.GetIndex({args[i]});");
                        break;

                }
            }
        }
    }
}

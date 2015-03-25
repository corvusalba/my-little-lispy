﻿using System.IO;
using System.Linq;
using CorvusAlba.MyLittleLispy.Runtime;
using CorvusAlba.MyLittleLispy.Hosting;

namespace CorvusAlba.MyLittleLispy.Client
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            if (!args.Any())
            {
                return new Repl(new ScriptEngine()).Loop();
            }
            
            using (var stream = new FileStream(args[0], FileMode.Open))
            {
                try
                {
                    (new ScriptEngine()).Execute(stream, true);
                    return 0;
                }
                catch (HaltException e)
                {
                    return e.Code;
                }
            }
        }
    }
}
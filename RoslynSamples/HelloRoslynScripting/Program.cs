using Roslyn.Scripting.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRoslynScripting
{
    class Program
    {
        static void Main(string[] args)
        {
            var se = new ScriptEngine();
            var session = se.CreateSession();
            var result = session.Execute("20 + 30");
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}

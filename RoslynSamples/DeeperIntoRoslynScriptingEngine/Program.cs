using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeeperIntoRoslynScriptingEngine
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialize our bank
            var bank = new DummyBank();
            //Create an instance of our scripting host with
            // bank as the context that’ll be used to create
            // the session
            var host = new ScriptingHost(bank);
            string codeLine;
            Console.Write(">");
            while ((codeLine = Console.ReadLine()) !=
            "Exit();")
            {
                try
                {
                    //Execute the code 
                    var res = host.Execute(codeLine);
                    //Write the result back to console if
                    // not null 
                    if (res != null)
                        Console.WriteLine(" = " + res.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(" !! " + e.Message);
                }
                Console.Write(">");
            }
            Console.ReadKey(false);
        }
    }
}

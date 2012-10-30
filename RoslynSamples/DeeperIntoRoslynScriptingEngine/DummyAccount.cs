using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeeperIntoRoslynScriptingEngine
{
    public class DummyAccount
    {
        public int Balance { get; set; }
        public string Owner { get; set; }

        public DummyAccount(int balance, string owner)
        {
            Balance = balance;
            Owner = owner;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeeperIntoRoslynScriptingEngine
{
    public class DummyBank
    {
        public DummyBank()
        {
            //Add some seed accounts for the demo
            Accounts = new List<DummyAccount>();
            {
                new DummyAccount(2000, "Joe");
                new DummyAccount(1020, "Jack");
                new DummyAccount(3433, "Jill");
            };
        }
        public void AddAccount(string name, int balance)
        {
            Accounts.Add(new
            DummyAccount(balance, name));
        }
        public List<DummyAccount> Accounts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using Roslyn.Compilers.CSharp;

namespace RoslynSyntaxWalker
{
    class Program
    {

        static void Main(string[] args)
        {
            const string code = @"
            class SimpleClass 
            { 
                public void SimpleMethod()
                {
                    var list = new List<int>();
                        list.Add(20);
                    list.Add(40);
                    var result = from item in list
                    where item > 20
                    select item;
                }
            }";
            //Parsing the syntax tree. Note that you’ve also got a ParseFile 
            //method as well
            var tree = SyntaxTree.ParseText(code);
            //Dumping the syntax tree
            tree.Dump();
            Console.ReadKey();
        }
    }
    

    public static class SyntaxTreeExtensions
    {
        public static void Dump(this SyntaxTree tree)
        {
            var writer = new ConsoleDumpWalker();
            writer.Visit(tree.GetRoot());
        }
        class ConsoleDumpWalker : SyntaxWalker
        {
            public override void Visit(SyntaxNode node)
            {
                int padding = node.Ancestors().Count();
                //To identify leaf nodes vs nodes with children
                string prepend = node.ChildNodes().Any() ? "[-]"
                : "[.]";
                //Get the type of the node
                string line = new String(' ', padding) + prepend
                + " " + node.GetType().ToString();
                //Write the line
                System.Console.WriteLine(line);
                base.Visit(node);
            }
        }
    }
}

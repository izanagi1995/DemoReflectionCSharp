using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoModel model = new DemoModel
            {
                BetterName = "Nicolas",
                MyName = "Bored C# Dev with headache"
            };
            Document d = new Document(model);
            Console.WriteLine(d.Render());
            Console.ReadKey();
        }
    }
}

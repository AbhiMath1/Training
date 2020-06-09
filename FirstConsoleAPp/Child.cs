using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class Child : Parent   //multiple inheritance through classes is not possible but we can acheive through interfaces
    {
        Child()
        {
            Console.WriteLine("Child Constructor");
        }
        public void ChildM1()
        {
            Console.WriteLine("from child method..");
        }
        public static void Main()
        {
            Child c = new Child();
            c.ChildM1();
            c.ParenM1();
            c.M1();
            Console.ReadKey();
        }
    }
}

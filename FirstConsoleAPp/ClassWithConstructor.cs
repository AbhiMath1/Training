using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ClassWithConstructor
    {
       
        ClassWithConstructor(int x)
        {
            Console.WriteLine(x);
            
        }
        public void Test()
        {
            Console.WriteLine("from test method");
        }
        public static void Main()
        {
            ClassWithConstructor c = new ClassWithConstructor(100);
            c.Test();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ExplicitKillingObj
    {
        int a;
        public string Info(string string1)
        {
            return string1 + "Hello";
        }
        public void Test(string string2)
        {
             string f=Info(string2);
            Console.WriteLine(f);
        }
        public static void Main()
        {
            ExplicitKillingObj obj = new ExplicitKillingObj();
            obj.Test("a");
            Console.ReadLine();
            //string r=obj.Info("45");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class CollectionsClass //encapsulation
    {
        public static void Main()
        {
            FirstConsoleAPp.Parent p = new FirstConsoleAPp.Parent();
            ArrayList al = new ArrayList();
            List<string> l = new List<string>();
            al.Add(37);
            al.Add(76.9876);
            al.Add("test");
            foreach(object i in al)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}

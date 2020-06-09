using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ReadingInput1
    {
        public static void Main()
        {
            Console.WriteLine("Nter Val1");
            int v1=int.Parse(Console.ReadLine());
            Console.WriteLine("Nter Val2");
            //int v2 = int.Parse(Console.ReadLine());
            string s = null;
            int v2 = Convert.ToInt32(s);
            int result = v1 + v2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

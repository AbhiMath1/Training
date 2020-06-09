using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ReadingInput
    {
        public static void Main()
        {
            Console.WriteLine("Enter Ur values");
            string Val1=Console.ReadLine();
            string Val2 = Console.ReadLine();
            string result = Val1 + Val2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

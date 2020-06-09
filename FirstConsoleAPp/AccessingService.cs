using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
namespace FirstConsoleAPp
{
    class AccessingService
    {
        public static void Main()
        {
            Service.Class1 c1 = new Service.Class1();
            c1.PerformSearch(3,45);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ExForeach
    {
        public static void Main()
        {
            int[] arr = new int[3];
            arr[0] = 55;
            arr[1] = 200;
            arr[2] = 300;
            foreach(int i in arr)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
           
        }
    }
}

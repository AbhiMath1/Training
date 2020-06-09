using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class ImpleVariables
    {
        public static void Main()
        {
             
            //Implicit variables
            var c = 220;
            var x = "Test";
            Console.WriteLine(c.GetType());
            Console.WriteLine(x.GetType());
            Console.ReadLine();
            //int x = 200;
            Object o = x;
            //valuetype to reference type object boxing
            Convert.ToInt32(o);
            //ref type to value type unboxing
            //Object super class type

            //12,"Delhi",76.76,"delhi,road 54"

            //Object o=300;

            

        }
    }
}

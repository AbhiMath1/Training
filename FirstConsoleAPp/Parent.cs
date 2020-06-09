using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
     class Parent
    {
       public  Parent()
        {
            Console.WriteLine("Parent class constructor");
        }
        protected void ParenM1()
        {
            Console.WriteLine("Parent Method");
        }
        public void M1()
        {

        }

        //internal within same solution
        //public outside solution
        //protected inherited members
        //private within class
    }
}

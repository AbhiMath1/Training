using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleAPp
{
    class TestGmail
    {
        public static void Main()
        {
            Gmail g = new Gmail();
            g.Drafts();
            g.Spam(21);
        }
    }
}

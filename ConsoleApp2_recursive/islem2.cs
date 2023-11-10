using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_recursive
{
    internal class islem2
    {
        public int F(int x)
        {
            if (x < 0)
                return -1;
            if (x == 0 || x == 1)
                return 1;
            else
                return x * F(x - 1);
        }
    }
}

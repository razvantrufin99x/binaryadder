using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binaryadder
{
    public class binaryops
    {

        public bitpair add(int a, int b)
        {

            bitpair x = new bitpair();


            if (a == 0 && b == 0)
            {
                x.a = 0;
                x.c = 0;
            }
            else if (a == 1 && b == 0)
            {
                x.a = 1;
                x.c = 0;
            }
            else if (a == 0 && b == 1)
            {
                x.a = 1;
                x.c = 0;
            }
            else if (a == 1 && b == 1)
            {
                x.a = 0;
                x.c = 1;
            }
            return x;
        }


    }
}




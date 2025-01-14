using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRandom
{
    internal class PseudoRandom
    {
        public static int Get1To1000()
        {
            return DateTime.Now.Millisecond;
        }
    }
}

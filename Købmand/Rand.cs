using System;
using System.Collections.Generic;
using System.Text;

namespace Købmand
{
    public static class Rand
    {
        public static Random rnd = new Random();

        public static int Range(int a, int b)
        {
            return rnd.Next(a, b);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormGarage
{
    public class RandomGenerator
    {
        static Random rnd = new Random();
        static object lockObj = new object();

        public static int Next(int min, int max)
        {
            int x = 0;
            lock (lockObj)
            {
                x = rnd.Next(min, max);
            }
            return x;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class A
    {
        public float[] linearEquation (float a, float b)
        {
            if (a == 0)
            {
                return null;
            }

            float[] x = new float[1];
            return x = new float[] { -b / a };
        }
    }
}

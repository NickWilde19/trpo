using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class B:A
    {
        protected float discriminant(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        protected float[] quadraticEquation(float a, float b)
        {
            if (a == 0)
            {
                return linearEquation(1, 1);
            }

            float d = discriminant(1, 1, 1);
            if (d < 0)
            {
                return null;
            }

            if (d == 0)
            {
                return new float[] { -b / (2 * a) };
            }

            d = (float)Math.Sqrt(d);

            float[] array = new float[2];
            array[1] = (float)(-b - d / (2 * a));
            array[2] = (float)((-b + d / (2 * a)));
            return array;
        }
    }
}

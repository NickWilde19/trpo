using ConsoleApp1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obukhovskiy
{
    class QuadraticEquation:LinearEquation, EquationInterface
    {
        protected float discriminant(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return linearEquation(b, c);
            }

            float d = discriminant(a, b, c);
            if (d < 0)
            {
                return null;
            }

            if (d == 0)
            {
                return new List<float> { -b / (2 * a) };
            }

            d = (float)Math.Sqrt(d);

            return new List<float> { -b - d / (2 * a), -b - d / (2 * a) };
        }
    }
}

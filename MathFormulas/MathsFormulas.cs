using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    public static class MathsFormulas
    {
        //Problem a - Basic Quadratic 
        public static float BasicQuadratic(float x)
        {
            //x^2 + 2x - 7
            return x * x + 2 * x - 7;
        }
        //Problem B - Quadratic Curve
        public struct QuadraticRoots
        {
            public float RootA;
            public float RootB;
            public bool hasRoots;
        }
        public static QuadraticRoots GetQuadraticRoots(float a, float b, float c)
        {
            //calc numerator
            float numA = -b + MathF.Sqrt(b * b - 4 * a * c);
            float numB = -b - MathF.Sqrt(b * b - 4 * a * c);

            //calc denominator 
            float den = 2 * a;

            //create roots objects
            QuadraticRoots roots = new QuadraticRoots();
            roots.RootA = numA / den;
            roots.RootB = numB / den;
            if ((b * b - 4 * a * c)<0)
            {
                roots.hasRoots = false;
            }
            else
            {
                roots.hasRoots = true;
            }

            //return
            return roots;

            
        }
        //Problem C - Linear Blend (lerp)
        public static float LinearBlend(float s, float e, float t)
        {
            float numA = e - s;
            float numB = t * numA;
            float blendedVar = s + numB;

            return blendedVar;
        }

        public static float DistanceBetweenTwoPoints(float x1, float x2, float y1, float y2)
        {
            return MathF.Sqrt((x2-x1)*(x2- x1) + (y2-y1)*(y2 - y1));
        }

        
    }
}

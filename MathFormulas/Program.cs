using MathFormulas;
using System;
using System.Diagnostics;

namespace AIE
{
    class Program
    {
        static void Main(string[] args)
        {
            float quad = MathsFormulas.BasicQuadratic(5.0f);
            Debug.Assert(quad == 28, "Invalid result for BasicQuadrativ");
            Debug.Assert(MathF.Abs(quad - 28) < 0.0001, "Valid");

            MathsFormulas.QuadraticRoots roots= MathsFormulas.GetQuadraticRoots(1,-5,4);

            float lerp = MathsFormulas.LinearBlend(4, 6, 0.5f);

            return;
        }
    }
}
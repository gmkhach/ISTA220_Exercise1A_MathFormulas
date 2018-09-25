#region System namespaces
using System;
using System.Collections.Generic;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class AdvancedFormulas : IAdvancedFormulas
    {
        public double[] QuadraticEquation(double a, double b, double c)
        {
            double[] x = new double[2];
            x[0] = (-b - Math.Sqrt(b * b - 4 * a * c))  / (2 * a);
            x[1] = (-b + Math.Sqrt(b * b - 4 * a * c))  / (2 * a);
            return x;
        }
    }
}
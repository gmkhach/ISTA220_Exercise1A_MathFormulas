#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class IntermediateFormulas : IIntermediateFormulas
    {
        public double AreaOfTriangle(double a, double b, double c)
        {
            double paremeter;
            double area;
            paremeter = 1 / 2 * (a + b + c);
            area = Math.Sqrt(paremeter * (paremeter - a) * (paremeter - b) * (paremeter - c));
            return area;
        }
    }
}

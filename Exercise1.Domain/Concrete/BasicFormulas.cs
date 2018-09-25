#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class BasicFormulas : IBasicFormulas
    {
        public double CircumferenceOfCircle(double radius)
        {
            double circumference;
            circumference = 2 * Math.PI * radius;
            return circumference;

        }

        public double AreaOfCircle(double radius)
        {
            double area;
            area = Math.PI * radius * radius;
            return area;
        }

        public double VolumeOfHemisphere(double radius)
        {
            double volume;
            volume = 1/2 * (3/4 * Math.PI * radius * radius * radius);
            return volume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLibrary.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            double area = 0;

            if (_radius > 0 && _radius != 0)
            {
                area = Math.PI * Math.Pow(_radius, 2);
            }
            else
            {
                throw new Exception("Радиус круга должен быть больше нуля!!!");
            }

            return area;
        }
    }
}

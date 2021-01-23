using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLibrary.Figures
{
    public class Triangle : Figure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            if(_firstSide > 0  
               && _secondSide > 0 
               && _thirdSide > 0)
            {
                var perimeter = _firstSide + _secondSide + _thirdSide;

                var halfPerimeter = perimeter / 2;

                var area = Math.Sqrt(halfPerimeter
                                     * (halfPerimeter - _firstSide)
                                     * (halfPerimeter - _secondSide)
                                     * (halfPerimeter - _thirdSide));

                return area;
            }
            else
            {
                throw new Exception("Параметры должны быть больше нуля!!!");
            }
            
        }

        public bool IsRightTriangle()
        {
            bool isRight;

            if (_firstSide > _secondSide && _firstSide > _thirdSide)
                isRight = PythagoreanTheorem(_firstSide, _secondSide, _thirdSide);
            else if (_secondSide > _thirdSide)
                isRight = PythagoreanTheorem(_secondSide, _firstSide, _thirdSide);
            else
                isRight = PythagoreanTheorem(_thirdSide, _firstSide, _secondSide);
            return isRight;
        }

        public bool PythagoreanTheorem(double maxSide, double sSide, double thSide)
        {
            if (Math.Pow(maxSide, 2) == Math.Pow(sSide, 2) + Math.Pow(thSide, 2))
                return true;
            else
                return false;
        }
    }
}

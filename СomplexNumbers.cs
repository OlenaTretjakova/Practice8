using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    struct СomplexNumbers
    {
        int RealPart;
        int ImaginaryPart;

        public СomplexNumbers(int realPart, int imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;

        }

        public void SumСomplexNumbers(int num1, int num2)
        {
            RealPart += num1;
            ImaginaryPart += num2;
        }

        public void DecreaseСomplexNumbers(int num1, int num2)
        {
            RealPart -= num1;
            ImaginaryPart -= num2;
        }

        public override string ToString()
        {
            return $"({RealPart} + {ImaginaryPart}*i)";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    struct Fraction
    {
        int Numerator;
        int Denominator;
        public Fraction (int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public void SumFraction(int otherNumerator, int otherDenominator)
        {
            if(this.Denominator!= otherDenominator)
            {
                this.Denominator *= otherDenominator;
                this.Numerator = this.Numerator * otherDenominator + otherNumerator * this.Denominator;


            }
            else 
            { 
                this.Numerator += otherNumerator;
            }

        }

        public void DecreaseFraction(int otherNumerator, int otherDenominator)
        {
            if (this.Denominator != otherDenominator)
            {
                this.Denominator *= otherDenominator;
                this.Numerator = this.Numerator * otherDenominator - otherNumerator * this.Denominator;

            }
            else
            {
                this.Numerator -= otherNumerator;
            }

        }

        public void Multiply(int otherNumerator, int otherDenominator)
        {
            this.Numerator *= otherNumerator;
            this.Denominator *= otherDenominator;

        }

        public void Division(int otherNumerator, int otherDenominator)
        {
            this.Denominator *= otherNumerator;

            this.Numerator *= otherDenominator;
        }

        public override string ToString()
        {
            return $"Fraction:{this.Numerator}/{this.Denominator}";
        }
    }
}

using System;

namespace BT2
{
    internal class MixedFraction 
        : Fraction
    {
        public int wholePart;
        public MixedFraction(){}
        public MixedFraction(int wholePart, int numertor, int denominator)
            :base(numertor , denominator)
        {
            this.wholePart = wholePart;
        }

        public MixedFraction(Fraction f)
        {
            Fraction value = new Fraction();
            int t = numertor / denominator;
            this.wholePart = t;
        }

        public override string ToString()
        {
            string s = "";
            //this.wholePart = numertor / denominator;
            this.numertor = numertor - wholePart * denominator;
            s = $"{wholePart} [{numertor}/ {denominator}]";
            return s;
        }
    }
}
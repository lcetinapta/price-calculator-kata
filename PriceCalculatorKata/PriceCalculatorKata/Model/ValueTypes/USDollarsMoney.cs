using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PriceCalculatorKata.Model.ValueTypes
{
    public struct USDollarsMoney
    {
        public readonly decimal Value;

        public USDollarsMoney(decimal value)
        {
            if(value<0) throw new ArgumentException("Vaue of money should be a positive number.");
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is decimal value1)
            {
                return value1 == Value;
            }

            return false;
        }

        public override string ToString()
        {
            return Value.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}

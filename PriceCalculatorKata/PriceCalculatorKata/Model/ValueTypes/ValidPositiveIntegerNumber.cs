using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculatorKata.Model.ValueTypes
{
    public struct ValidPositiveIntegerNumber
    {
        public readonly int Value;

        public ValidPositiveIntegerNumber(int value)
        {
            if(value<0) throw new ArgumentException($"Parameter {nameof(value)} must be a valid positive integer number.");
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is int value2)
            {
                return Value == value2;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}

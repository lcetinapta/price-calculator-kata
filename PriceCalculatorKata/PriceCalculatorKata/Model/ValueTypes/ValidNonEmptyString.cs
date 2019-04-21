using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculatorKata.Model.ValueTypes
{
    public struct ValidNonEmptyString
    {
        private readonly string _value;

        public ValidNonEmptyString(string value)
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"Parameter '{nameof(value)}' must be a valid non null and non empty string.");

            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public override bool Equals(object obj)
        {
            if (obj is string value)
            {
                return String.CompareOrdinal(_value, value)==0;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

    }
}

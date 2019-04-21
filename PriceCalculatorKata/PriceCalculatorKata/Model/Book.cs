using System;
using System.Collections.Generic;
using System.Text;
using PriceCalculatorKata.Model.ValueTypes;

namespace PriceCalculatorKata.Model
{
    public class Book:Product
    {
        protected Book(ValidNonEmptyString name, ValidPositiveIntegerNumber uid, USDollarsMoney basePrice) : base(name, uid, basePrice)
        {
        }


        public static Product CreateNew(ValidNonEmptyString name, ValidPositiveIntegerNumber uid, USDollarsMoney basePrice)
        {
            return new Book(name,uid, basePrice);
        }
    }
}

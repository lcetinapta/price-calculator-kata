using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using PriceCalculatorKata.Model.ValueTypes;

namespace PriceCalculatorKata.Model
{
    public abstract class Product
    {
        public string Name { get; private set; }
        public int Uid { get; private set; }
        private  USDollarsMoney BasePrice{ get; set; }

        protected Product(ValidNonEmptyString name, ValidPositiveIntegerNumber uid, USDollarsMoney basePrice)
        {
            Name = name.ToString();
            Uid = uid.Value;
            BasePrice = basePrice;
        }

        public USDollarsMoney GetBasePrice()
        {
            return BasePrice;
        }

        public USDollarsMoney GetFinalPrice(decimal tax = 20M)
        {
            return new USDollarsMoney((BasePrice.Value * tax / 100) + BasePrice.Value);
        }

        public void Rename(ValidNonEmptyString newName)
        {
            Name = newName.ToString();
        }

        public void ChangeUidCode(ValidPositiveIntegerNumber newUid)
        {
            Uid = newUid.Value;
        }

        public void ChangeBaserice(USDollarsMoney newPrice)
        {
            this.BasePrice = newPrice;
        }

        public string PrintProductInfo(decimal tax = 0)
        {
            return $"Product price reported as {GetBasePrice().ToString()} before tax and {GetFinalPrice(tax).ToString()} after {tax}% tax.";
        }

    }
}

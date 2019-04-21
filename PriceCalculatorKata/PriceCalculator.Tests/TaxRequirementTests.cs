using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using PriceCalculatorKata.Model;
using PriceCalculatorKata.Model.ValueTypes;
using Xunit;

namespace PriceCalculator.Tests
{
    public class TaxRequirementTests
    {
        public TaxRequirementTests()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        [Fact]
        public void Should_Print_Exact_Product_Info()
        {
            var book = Book.CreateNew(new ValidNonEmptyString("The Little Prince"), new ValidPositiveIntegerNumber(12345), new USDollarsMoney(20.25M));

            Func<string>  printProductInfoWithTaxOf20 = () => book.PrintProductInfo(20);
            Func<string> printProductInfoWithTaxOf21 = () => book.PrintProductInfo(21);

            printProductInfoWithTaxOf20.Invoke().Should().BeEquivalentTo("Product price reported as $20.25 before tax and $24.30 after 20% tax.");
            printProductInfoWithTaxOf21.Invoke().Should().BeEquivalentTo("Product price reported as $20.25 before tax and $24.50 after 21% tax.");
        }
    }
}

using NUnit.Framework;

using TaxCalculator;

namespace TaxCalculatorTest
{
    [TestFixture]
    public class TaxCalculatorTest
    {
       [Test]     
       public void TaxIncome()
        {
            var format = new TaxCalculatorService();
            var result = format.CalculateTaxableIncome(4000000);
            Assert.That(result, Is.EqualTo("2,744,000"));
        }
    }
}

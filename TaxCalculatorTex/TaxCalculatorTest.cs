using TaxCalculator;
using NUnit.Framework;
using System;

namespace TaxCalculator.UnitTest
{
    public class TaxCalculatorTest
    {
        [Test]
        public void CalculatetaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxableIncome(50000);
            //Assert
            Assert.AreEqual(241600m, result);
        }


        [Test]
        public void CalculatetaxableIncome40000()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxableIncome(40000);
            //Assert
            Assert.AreEqual(153280m, result);
        }


        [Test]
        public void CalculatetaxableIncomeOf700000()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxableIncome(70000);
            //Assert
            Assert.AreEqual(418240m, result);
        }


        [Test]
        public void CalculatetaxableIncomewithnegativeorzerovalue()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Assert+Act
            Assert.Throws<ArgumentException>(() => income.CalculateTaxableIncome(-4000000m));
           
        }


        [Test]
        public void CalculatetaxableIncomewithnegative()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Assert+Act
            Assert.Throws<ArgumentException>(() => income.CalculateTaxableIncome(-13));

        }


        [Test]
        public void CalculateMonthlyTax()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.GetMonthlyTax(300000);
            //Assert
            Assert.AreEqual(33534.666666666666666666666667m, result);
        }


        [Test]
        public void CalculateMonthlyOf9845000Tax()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.GetMonthlyTax(9845000m);
            //Assert
            Assert.AreEqual(1698059.4666666666666666666667m, result);
        }


        [Test]
        public void CalculateYearlyTax()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.GetYearlyTax(2449600m);
            //Assert
            Assert.AreEqual(402416m, result);
        }


        [Test]
        public void CalculateYearlyTaxOf600000()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.GetYearlyTax(600000);
            //Assert
            Assert.AreEqual(54000m, result);
        }


        [Test]
        public void Calculate7PercentOfIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForFirst300000(600000m);
            //Assert
            Assert.AreEqual(42000m, result);
        }

        [Test]
        public void CalculatetaxableIncomewithLessThan30000()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Assert+Act
            Assert.Throws<ArgumentException>(() => income.CalculateTaxableIncome(10000));
        }


        [Test]
        public void Calculate7PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForFirst300000(600000m);
            //Assert
            Assert.AreEqual(42000m, result);
        }
         

        [Test]
        public void Calculate15PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForFirst500000(900000);
            //Assert
            Assert.AreEqual(135000m, result);
        }


        [Test]
        public void Calculate15PercentOfIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForFirst500000(400000);
            //Assert
            Assert.AreEqual(60000m, result);
           
        }


        [Test]
        public void Calculate11PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForSecond300000(678900m);
            //Assert
            Assert.AreEqual(74679m, result);
        }

        [Test]
        public void Calculate11PercentTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForSecond300000(6700m);
            //Assert
            Assert.AreEqual(737m, result);
        }


        [Test]
        public void Calculate19PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForSecond500000(678900m);
            //Assert
            Assert.AreEqual(128991m, result);
        }


        [Test]
        public void Calculate19PercentTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxForSecond500000(6700m);
            //Assert
            Assert.AreEqual(1273m, result);
        }


        [Test]
        public void Calculate21PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxFor1600000(1600000m);
            //Assert
            Assert.AreEqual(336000m, result);
        }


        [Test]
        public void Calculate21PercentTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxFor1600000(67300m);
            //Assert
            Assert.AreEqual(14133m, result);
        }


        [Test]
        public void Calculate24PercentOfTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxFor3200000(676900m);
            //Assert
            Assert.AreEqual(162456, result);
        }


        [Test]
        public void Calculate24PercentTaxableIncome()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateTaxFor3200000(360000m);
            //Assert
            Assert.AreEqual(86400m, result);
        }


        [Test]
        public void CalulateBelowAndEqual300000AreEqual()
        {
            //Arrange
            var income=new TaxCalculatorService();
            //Act
            var result = income.CalculateBelowAndEqual300000(123000);
            //Assert
            Assert.AreEqual(8610m, result);
        }

        [Test]
        public void CalulateBelowAndEqual300000AreNotEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateBelowAndEqual300000(123000);
            //Assert
            Assert.AreNotEqual(23000m, result);
        }

        [Test]
        public void CalculateAbove300000AndEqual600000AreNotEqual()
        {
            //Arrange
            var income=new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove300000AndEqual600000(500000);
            //Assert
            Assert.AreNotEqual(result, 23000m);
        }

        [Test]
        public void CalculateAbove300000AndEqual600000AreEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove300000AndEqual600000(500000);
            //Assert
            Assert.AreEqual(43000m, result);
        }

        [Test]
        public void CalculateAbove600000AndEqual1100000AreEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove600000AndEqual1100000(900000);
            //Assert
            Assert.AreEqual(99000m, result);
        }

        [Test]
        public void CalculateAbove600000AndEqual1100000AreNotEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove600000AndEqual1100000(900000);
            //Assert
            Assert.AreNotEqual(43000m, result);
        }

        [Test]
        public void CalculateAbove1100000AndEqual1600000AreEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1100000AndEqual1600000(1234000);
            //Assert
            Assert.AreEqual(154460m, result);
        }

        [Test]
        public void CalculateAbove1100000AndEqual1600000AreNotEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1100000AndEqual1600000(1234000);
            //Assert
            Assert.AreNotEqual(123000m, result);
        }

        [Test]
        public void CalculateAbove1600000AndEqual3200000AreEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1600000AndEqual3200000(2500000);
            //Assert
            Assert.AreEqual(413000m, result);
        }

        [Test]
        public void CalculateAbove1600000AndEqual3200000AreNotEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1100000AndEqual1600000(1234000);
            //Assert
            Assert.AreNotEqual(12893000m, result);
        }

        [Test]
        public void CalculateAbove3200000AreEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1600000AndEqual3200000(6700000);
            //Assert
            Assert.AreEqual(1295000m, result);
        }

        [Test]
        public void CalculateAbove3200000AreNotEqual()
        {
            //Arrange
            var income = new TaxCalculatorService();
            //Act
            var result = income.CalculateAbove1100000AndEqual1600000(7900000);
            //Assert
            Assert.AreNotEqual(12893786000m, result);
        }
    }
}

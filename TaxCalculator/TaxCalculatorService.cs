using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxCalculatorService 
    {
        public decimal CalculateBelowAndEqual300000(decimal annualSalary)
        {
            return CalculateTaxForFirst300000((annualSalary));
        }

        public decimal CalculateAbove300000AndEqual600000(decimal annualSalary)
        {
            decimal result = 0;
            result += CalculateTaxForFirst300000(300000);
            annualSalary -= 300000;
            result += CalculateTaxForSecond300000(annualSalary);
            return result;
        }

        public decimal CalculateAbove600000AndEqual1100000(decimal annualSalary)
        {
            decimal tax = 0;
            tax += CalculateTaxForFirst300000(300000);
            annualSalary -= 300000;
            tax += CalculateTaxForSecond300000(300000);
            annualSalary -= 300000;
            tax += CalculateTaxForFirst500000(annualSalary);
            return tax;
        }

        public decimal CalculateAbove1100000AndEqual1600000(decimal annualSalary)
        {
            decimal tax=0;
            tax += CalculateTaxForFirst300000(300000);
            annualSalary -= 300000;
            tax += CalculateTaxForSecond300000(300000);
            annualSalary -= 300000;
            tax += CalculateTaxForFirst500000(500000);
            annualSalary -= 500000;
            tax += CalculateTaxForSecond500000(annualSalary);
            return tax;

        }

        public decimal CalculateAbove1600000AndEqual3200000(decimal taxableIncome)
        {
            decimal tax = 0;
            tax += CalculateTaxForFirst300000(300000);
            taxableIncome -= 300000;
            tax += CalculateTaxForSecond300000(300000);
            taxableIncome -= 300000;
            tax += CalculateTaxForFirst500000(500000);
            taxableIncome -= 500000;
            tax += CalculateTaxForSecond500000(500000);
            taxableIncome -= 500000;
            tax += CalculateTaxFor1600000(taxableIncome);
            return tax;
        }

        public decimal CalculateAbove3200000(decimal taxableIncome)
        {
            decimal tax = 0;
            tax += CalculateTaxForFirst300000(300000);
            taxableIncome -= 300000;
            tax += CalculateTaxForSecond300000(300000);
            taxableIncome -= 300000;
            tax += CalculateTaxForFirst500000(500000);
            taxableIncome -= 500000;
            tax += CalculateTaxForSecond500000(500000);
            taxableIncome -= 500000;
            tax += CalculateTaxFor1600000(1600000);
            taxableIncome -= 1600000;
            tax += CalculateTaxFor3200000(taxableIncome);
            return tax;
        }

        public decimal CalculatePension(decimal GI)
        {
            var pension = (8 / 100m) * GI;
            return pension;
        }

        public decimal CalculateTaxableIncome(decimal salary)
        {
            if(salary <= 30000)
            {
                throw new ArgumentException("Salary not taxable");
            }
            decimal annualSalary = salary*12;
            decimal pension = CalculatePension(annualSalary);
            decimal grossIncome = annualSalary - pension;
            decimal twentyGross = (20/100m) * grossIncome;
            decimal ConsolidatedReliefAllowance = 0;
            if (200000 > ((1 / 100m) * annualSalary))
            {
                ConsolidatedReliefAllowance += 200000;
            }
            else
            {
                ConsolidatedReliefAllowance += ((1 / 100m) * annualSalary);
            }
            decimal total = pension + twentyGross + ConsolidatedReliefAllowance;
            decimal taxableIncome = annualSalary - total;
            return taxableIncome;
        }

        public decimal CalculateTaxFor1600000(decimal salary)
        {
            return salary * (21 / 100m);  
        }

        public decimal CalculateTaxFor3200000(decimal salary)
        {
            return salary * (24 / 100m);
        }

        public decimal CalculateTaxForFirst300000(decimal salary)
        {
            return (salary * (7 / 100m));
        }

        public decimal CalculateTaxForFirst500000(decimal salary)
        {
            return (salary * (15 / 100m));
        }

        public decimal CalculateTaxForSecond300000(decimal salary)
        {
            return (salary * (11 / 100m));
        }

        public decimal CalculateTaxForSecond500000(decimal salary)
        {
            return salary * (19 / 100m);
        }

        public decimal GetMonthlyTax(decimal salary)
        {
            decimal annualSalary=CalculateTaxableIncome(salary);
              decimal yearlyTax=GetYearlyTax(annualSalary);
            return yearlyTax/12;
        }

        public decimal GetYearlyTax(decimal taxableIncome)
        {
            
            if(taxableIncome <= 300000)
            {
                return CalculateBelowAndEqual300000(taxableIncome);
            }
            else if(taxableIncome > 300000 && taxableIncome <= 600000)
            {
                return CalculateAbove300000AndEqual600000(taxableIncome);
            }
            else if(taxableIncome > 600000 && taxableIncome <= 1100000)
            {
                return CalculateAbove600000AndEqual1100000(taxableIncome);
            }
            else if(taxableIncome > 1100000 && taxableIncome <= 1600000)
            {
               return CalculateAbove1100000AndEqual1600000(taxableIncome) ;
            }
            else if(taxableIncome > 1600000 && taxableIncome <= 3200000)
            {
                return CalculateAbove1600000AndEqual3200000(taxableIncome);
            }
            else
            {
                return CalculateAbove3200000(taxableIncome);
            }
         
        }
    }
}

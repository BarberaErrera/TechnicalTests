using TaxApp.Classes;
using TaxApp.Interface;

namespace TaxApp.Data
{
    public class TaxData : ITaxData
    {
        public double GetMonthlyTaxRate(double monthlySalary)
        {

            if (monthlySalary >= 5000 && monthlySalary <= 10000)
            {
                return 5;
            }
            if (monthlySalary >= 10001 && monthlySalary <= 20000)
            {
                return 7.5;
            }
            if (monthlySalary >= 20001 && monthlySalary <= 35000)
            {
                return 9;
            }
            if (monthlySalary >= 35001 && monthlySalary <= 50000)
            {
                return 15;
            }
            if (monthlySalary >= 50001 && monthlySalary <= 70000)
            {
                return 25;
            }
            return monthlySalary >= 70001 ? 30 : 0;
        }

        public TaxAgeBenefit GetAgeBenefit(int age)
        {
            if (age >= 18 && age <= 50)
                return new TaxAgeBenefit {MonthlySalaryRelief = 2000, PerentageOfTaxDecuction = 100};
            return age > 50 ? new TaxAgeBenefit { MonthlySalaryRelief = 5000, PerentageOfTaxDecuction = 85 } : null;
        }
    }
}
using TaxApp.Data;
using TaxApp.Interface;

namespace TaxApp.Controller
{
    public class TaxController : ITaxCalculator
    {
        private readonly ITaxData _taxData;

        public TaxController()
        {
            _taxData = new TaxData();
        }

        public double CalculateTax(double annualSalary, int age)
        {
            var monthlySalary = (annualSalary / 12);
            var ageBenefit = _taxData.GetAgeBenefit(age);
            if (ageBenefit != null)
            {
                var salaryRelief = ageBenefit.MonthlySalaryRelief;
                var percentageOfTaxDeduction = ageBenefit.PerentageOfTaxDecuction;

                var newMonthlySalary = (monthlySalary - salaryRelief);
                var monthlyTaxRate = _taxData.GetMonthlyTaxRate(newMonthlySalary);
                var newTaxRate = ((percentageOfTaxDeduction / 100) * (monthlyTaxRate / 100));
                var taxPayable = (newMonthlySalary * newTaxRate) * 12;
                return taxPayable;
            }
            else
            {
                var monthlyTaxRate = _taxData.GetMonthlyTaxRate(monthlySalary);
                var taxPayable = (monthlySalary * (monthlyTaxRate/100)) * 12;
                return taxPayable;
            }
        }
    }
}
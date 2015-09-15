using TaxApp.Classes;

namespace TaxApp.Interface
{
    internal interface ITaxData
    {
        double GetMonthlyTaxRate(double annualSalary);

        TaxAgeBenefit GetAgeBenefit(int age);
    }
}
namespace TaxApp.Interface
{
    internal interface ITaxCalculator
    {
        double CalculateTax(double annualSalary, int age);
    }
}
using System;
using System.Globalization;
using System.Windows.Forms;
using TaxApp.Controller;
using TaxApp.Interface;

namespace TaxApp
{
    public partial class frmTaxPayable : Form
    {
        private readonly ITaxCalculator _iTaxCalculator;

        public frmTaxPayable()
        {
            InitializeComponent();
            _iTaxCalculator = new TaxController();
        }

        private void btnCalcTax_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes()) return;

            var salaryPerAnnum = Convert.ToDouble(txtSalaryPerAnnum.Text);
            var age = Convert.ToInt32(txtAge.Text);

            if (Convert.ToDouble(salaryPerAnnum) < 0)
                MessageBox.Show(@"Please enter a valid annual salary");
            if (Convert.ToInt32(age) < 0)
                MessageBox.Show(@"Please enter a valid age");

            var taxPayable = _iTaxCalculator.CalculateTax(salaryPerAnnum, age);
            txtTaxPayable.Text = taxPayable.ToString(CultureInfo.InvariantCulture);
        }

        private bool ValidateTextBoxes()
        {
            double salary;
            double.TryParse(txtSalaryPerAnnum.Text.Trim(), out salary);
            if (salary <= 0.0)
            {
                MessageBox.Show(@"Please enter a valid annual salary");
                return false;
            }
            int age;
            int.TryParse(txtAge.Text.Trim(), out age);
            if (age > 0) return true;
            MessageBox.Show(@"Please enter a valid age");
            return false;
        }
    }
}
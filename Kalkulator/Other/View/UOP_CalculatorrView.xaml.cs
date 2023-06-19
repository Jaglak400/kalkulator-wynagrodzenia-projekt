using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator.Other.View
{

    public partial class UOP_CalculatorView : UserControl
    {
        public UOP_CalculatorView()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double salaryTax = 0;
                double monthlySalary = double.Parse(salaryTextBox.Text);
                double retirementInsuranceRate = (9.76 + 1.5 + 2.45) / 100;
                double healthInsuranceRate = 0.09;
                double taxRate = 0.12;
                


                double retirementInsurance = monthlySalary * retirementInsuranceRate;
                double healthInsurance = monthlySalary * healthInsuranceRate;
                if (double.Parse(salaryTextBox.Text) > 9999)
                {
                    salaryTax = 300;
                }
                else
                {
                    salaryTax = 250;
                }
                double taxBase = monthlySalary - retirementInsurance - healthInsurance - salaryTax;
                double tax = Math.Round(taxBase * taxRate, 2, MidpointRounding.AwayFromZero);
                double netIncome = monthlySalary - retirementInsurance - healthInsurance - tax;

                retirementInsuranceTextBlock.Text = retirementInsurance.ToString("N2");
                healthInsuranceTextBlock.Text = healthInsurance.ToString("N2");
                taxableIncomeTextBlock.Text = taxBase.ToString("N2");
                taxTextBlock.Text = tax.ToString("N2");
                netIncomeTextBlock.Text = netIncome.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowe dane. Proszę wprowadzić poprawną liczbę.");
            }

        }

        private void salaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

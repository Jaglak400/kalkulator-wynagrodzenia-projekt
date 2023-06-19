using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator.Other.View
{
    public partial class IT_comparerView : UserControl
    {

    

        //Pula danych o zarobkach per grade A, B, C
        List<decimal> gradeA = new List<decimal>()
        {
            10400.00m,
            4500.00m,
            6000.00m,
            8000.00m,
            13200.00m,
            6500.00m,
            6500.00m,
            6800.00m,
            6500.00m,
            6500.00m,
            10000.00m,
            6000.00m,
            6000.00m,
            5200.00m,
            7500.00m,
            7000.00m,
            9500.00m,
            45000.00m,
            6500.00m,
            4500.00m,
            4930.00m,
            7500.00m,
            7500.00m,
            6800.00m,
            4400.00m,
            3900.00m,
            4450.00m,
            7000.00m,
            7450.00m,
            3630.00m,
            3700.00m,
            4509.00m,
            10350.00m,
            7800.00m,
            5700.00m,
            5500.00m,
            3700.00m,
            4200.00m,
            4400.00m,
            4450.00m,
            4509.00m
        };
            List<decimal> gradeB = new List<decimal>()
        {
            4700.00m,
            4800.00m,
            5000.00m,
            5000.00m,
            5000.00m,
            5000.00m,
            5000.00m,
            5500.00m,
            5500.00m,
            5500.00m,
            5700.00m,
            5900.00m,
            6000.00m,
            6000.00m,
            6000.00m,
            6000.00m,
            6075.00m,
            6500.00m,
            6500.00m,
            6500.00m,
            6900.00m,
            7000.00m,
            7000.00m,
            7000.00m,
            7000.00m,
            7100.00m,
            7200.00m,
            7500.00m,
            7500.00m,
            7500.00m,
            7500.00m,
            7650.00m,
            7700.00m,
            7800.00m,
            8000.00m,
            8000.00m,
            8000.00m,
            8500.00m,
            8500.00m,
            8600.00m,
            9000.00m,
            9000.00m,
            9000.00m,
            10000.00m,
            10000.00m,
            10000.00m,
            10000.00m,
            10350.00m,
            11000.00m,
            11000.00m,
            11000.00m,
            12000.00m,
            12000.00m,
            12000.00m,
            13000.00m,
            14000.00m,
            14450.00m,
            15000.00m,
            16000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            22000.00m,
            6000.00m,
            6000.00m,
            6500.00m,
            10000.00m,
            10000.00m
        };
            List<decimal> gradeC = new List<decimal>()
        {
            15000.00m,
            15120.00m,
            15175.00m,
            15200.00m,
            15500.00m,
            15500.00m,
            15500.00m,
            15500.00m,
            15600.00m,
            16000.00m,
            16000.00m,
            16000.00m,
            16000.00m,
            16000.00m,
            16300.00m,
            16700.00m,
            16800.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17000.00m,
            17200.00m,
            17500.00m,
            17500.00m,
            18000.00m,
            18000.00m,
            18000.00m,
            18000.00m,
            18000.00m,
            18000.00m,
            18000.00m,
            18500.00m,
            19000.00m,
            19000.00m,
            19000.00m,
            19300.00m,
            19400.00m,
            19500.00m,
            19500.00m,
            19500.00m,
            20000.00m,
            20000.00m,
            20000.00m,
            20000.00m,
            20000.00m,
            20000.00m,
            20000.00m,
            21000.00m,
            21000.00m,
            22000.00m,
            22000.00m,
            22000.00m,
            22000.00m,
            22000.00m,
            22000.00m,
            22500.00m,
            23000.00m,
            23000.00m,
            24000.00m,
            24150.00m,
            24150.00m,
            24500.00m,
            25000.00m,
            25000.00m,
            25000.00m,
            25500.00m,
            25500.00m,
            26000.00m,
            27000.00m,
            27400.00m,
            27500.00m,
            28000.00m,
            28000.00m,
            28000.00m,
            28000.00m,
            28000.00m,
            29000.00m,
            30000.00m,
            30000.00m,
            30000.00m,
            30000.00m,
            31000.00m,
            32000.00m,
            35000.00m,
            35000.00m,
            36389.00m,
            43000.00m,
            60000.00m,
            61000.00m,
            75000.00m,
            15000.00m,
            15000.00m,
            14500.00m,
            14500.00m,
            14500.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            15000.00m,
            14000.00m,
            14000.00m,
            13000.00m,
            13000.00m,
            13500.00m,
            13500.00m,
            13500.00m,
            13800.00m,
            13900.00m,
            14000.00m,
            14000.00m,
            14000.00m,
            14000.00m,
            12500.00m,
            12500.00m,
            12500.00m,
            12500.00m,
            12500.00m,
            12850.00m,
            13000.00m,
            13000.00m,
            13000.00m,
            12000.00m,
            12000.00m,
            12000.00m,
            11500.00m,
            11000.00m,
            11000.00m,
            10000.00m,
            9000.00m,
            8500.00m,
            8500.00m
        };


        decimal dosA = 1.4M; // Lat doswiadczenia for grade A
        decimal dosB = 3.6M; // Lat doswiadczenia for grade B
        decimal dosC = 9.5M; // Lat doswiadczenia for grade C

        public IT_comparerView()
        {
            InitializeComponent();
            boxGrade.SelectionChanged += boxGrade_SelectionChanged;
        }

        //logika do odpalania buttona
        private void boxGrade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (boxGrade.SelectedItem != null)
            {
                calculatebutton.IsEnabled = true;
            }
            else
            {
                calculatebutton.IsEnabled = false;
            }
        }
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {


            decimal zarobkiNetto;
            decimal lataDoswiadczenia;
            decimal sredniaDoswiadczenia = 0;
            decimal srednieZarobki = 0;

            try
            {
                zarobkiNetto = decimal.Parse(txtNetto.Text);
                lataDoswiadczenia = decimal.Parse(txtLata.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nalezy wprowadzic poprawne dane");
                return;
            }

            ComboBoxItem gradeItem = (ComboBoxItem)boxGrade.SelectedItem;
            string gradeContent = gradeItem.Content.ToString();

            List<decimal> gradeCurrent = new List<decimal>();

            try
            {
                if (gradeContent == "A (Junior)")
                {
                    sredniaDoswiadczenia = dosA;
                    srednieZarobki = gradeA.Average();
                    gradeCurrent = gradeA;
                }
                else if (gradeContent == "B (Senior)")
                {
                    sredniaDoswiadczenia = dosB;
                    srednieZarobki = gradeB.Average();
                    gradeCurrent = gradeB;
                }
                else if (gradeContent == "C (Specjalista)")
                {
                    sredniaDoswiadczenia = dosC;
                    srednieZarobki = gradeC.Average();
                    gradeCurrent = gradeC;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nalezy wprowadzic poprawne dane");
                return;
            }

            decimal counterL = 0;
            decimal counterM = 0;

            foreach (decimal gradeValue in gradeCurrent)
            {
                if (gradeValue > zarobkiNetto)
                {
                    counterL++;
                }
                else
                {
                    counterM++;
                }
            }

            decimal percentL = (counterL / gradeCurrent.Count) * 100;
            decimal percentM = (counterM / gradeCurrent.Count) * 100;

            table_doswiadczenie.Text = sredniaDoswiadczenia.ToString("0.00");
            table_twoje.Text = zarobkiNetto.ToString("0.00");
            table_zarobkiGrade.Text = srednieZarobki.ToString("0.00");
            table_zarabw.Text = table_zarabw.Text = $"Zarabiasz {percentM.ToString("0.00")}% więcej od osób z listy i {percentL.ToString("0.00")}% mniej.";






        }
    }
}

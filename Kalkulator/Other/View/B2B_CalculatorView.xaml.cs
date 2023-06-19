using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    /// <summary>
    /// Logika interakcji dla klasy B2B_CalculatorView.xaml
    /// </summary>
    public partial class B2B_CalculatorView : UserControl
    {
        public B2B_CalculatorView()
        {
            InitializeComponent();
            zus.SelectionChanged += Zus_SelectionChanged;
        }

      

        //logika do buttona 
        private void Zus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (zus.SelectedItem != null)
            {
                calculateButton.IsEnabled = true;
            }
            else
            {
                calculateButton.IsEnabled = false;
            }
        }
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {


           
            decimal wynagrodzenieBrutto;
            decimal skladkaZus = 0;
            decimal podatekDochodowy = 0;
            decimal ubezpieczenieChorobow = 0;
            decimal kosztyDzialalnosci;
            decimal minimalneWynagrodzenie = 3490;
            decimal podstawaSkladki = minimalneWynagrodzenie;
            decimal rokPodatkowy;
            decimal procentSkladki = 0; 

            //assignowanie danych z interfrejsu 
            try
            {
                wynagrodzenieBrutto = decimal.Parse(txtWynagrodzenieBrutto.Text);
                kosztyDzialalnosci = decimal.Parse(txtKosztyDzialalnosci.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nalezy wprowadzic poprawne dane");
                return;
            }

            ComboBoxItem _zus = (ComboBoxItem)zus.SelectedItem;
            string selectedPodatek = string.Empty;
            if (radioButton12_32.IsChecked == true)
            {
                selectedPodatek = "12%/32%";
            }
            else if (radioButton19.IsChecked == true)
            {
                selectedPodatek = "19%";
            }

            string selectedUbezpieczenie = string.Empty;    
            if (radioButton_tak.IsChecked == true)
            {
                selectedUbezpieczenie = "tak";
            }
            else if(radioButton_nie.IsChecked == true)
            {
                selectedUbezpieczenie = "nie";
            }

            decimal selectedRok = 0;
            if (Radiobutton_Rok1.IsChecked == true)
            {
                selectedRok = 1;
            }
            else if (Radiobutton_Rok2.IsChecked == true)
            {
                selectedRok = 2;
            }

            else
            {
                selectedRok = 0;
            }
            //wybor wart. na pdst. wyb. usera zus//

            if (_zus.Content.ToString() == "Brak skladki ZUS")
            {
                skladkaZus = 0;
            }

            else if (_zus.Content.ToString() == "Preferencyjna skladka ZUS")
            {
                if (selectedRok == 1)
                {
                    procentSkladki = 0.3m;
                }

                else if (selectedRok == 2)
                {
                    procentSkladki = 0.6m;
                }

                skladkaZus = podstawaSkladki * procentSkladki;
            }

            else if(_zus.Content.ToString() == "Normalna skladka ZUS")
            {
                decimal skladkaEmerytalna = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.0976m; // Składka emerytalna 9.76%
                decimal skladkaRentowa = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.015m; // Składka rentowa 1.5%
                decimal skladkaChorobowa = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.0245m; // Składka chorobowa 2.45%

                skladkaZus = skladkaEmerytalna + skladkaRentowa + skladkaChorobowa;


            }

            //wybor wart. na pdst. wyb. usera podatek//

            if (selectedPodatek == "12%/32%")
            {
                decimal prog = wynagrodzenieBrutto * 12m;
                if (prog <= 85528m)
                {
                    podatekDochodowy = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.12m; //opod. 12m% z kw. brutto
                }

                else
                {
                    decimal podstawaOpodatkowana = (wynagrodzenieBrutto - kosztyDzialalnosci) - (85528m /12);
                    decimal podatekNaliczony = (10263.84m/12) + (podstawaOpodatkowana * 0.32m);
                    podatekDochodowy = podatekNaliczony;
                }
            }

            else if(selectedPodatek == "19%")
            {
                podatekDochodowy = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.19m; //procent 19% od zarobkku brutt            
            }

            //wybor wart. na pdst. wyb. usera ubezp//
            if (selectedUbezpieczenie == "tak")
            {
                ubezpieczenieChorobow = (wynagrodzenieBrutto - kosztyDzialalnosci) * 0.0245m;
            }

            else if (selectedUbezpieczenie == "nie")
            {
                ubezpieczenieChorobow = 0;
            }

            //obliczenia $ bruto 

            decimal wynagrodzenieNetto = wynagrodzenieBrutto - skladkaZus - podatekDochodowy - ubezpieczenieChorobow - kosztyDzialalnosci;
            table_brutto.Text = wynagrodzenieBrutto.ToString("0.00");
            table_netto.Text = wynagrodzenieNetto.ToString("0.00");
            table_podatek.Text = podatekDochodowy.ToString("0.00");
            table_ubezpieczenie.Text = ubezpieczenieChorobow.ToString("0.00");
            table_zus.Text = skladkaZus.ToString("0.00");    

        }

        private void zus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)zus.SelectedItem;

            if (selectedItem.Content.ToString() == "Preferencyjna skladka ZUS")
            {
                Radiobutton_Rok1.IsEnabled = true;
                Radiobutton_Rok2.IsEnabled = true;
            }
            else
            {
                Radiobutton_Rok1.IsEnabled = false;
                Radiobutton_Rok2.IsEnabled = false;
            }

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}


public partial class B2B_CalculatorView : UserControl, INotifyPropertyChanged
{
    private bool _isPopupOpen;
    public bool IsPopupOpen
    {
        get { return _isPopupOpen; }
        set
        {
            _isPopupOpen = value;
            OnPropertyChanged(nameof(IsPopupOpen));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


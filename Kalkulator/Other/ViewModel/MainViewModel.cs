using Kalkulator.Core;
using Kalkulator.Other.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.Other.ViewModel
{
    class MainViewModel : ObservableObject
    {
        
        /* te funkcje przełączają się między widokami w aplikacji */
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand UOP_CalculatorViewCommand { get; set; }
        public RelayCommand B2B_CalculatorViewCommand { get; set; }
        public RelayCommand IT_comparerViewCommand { get; set; }

        /* obsługują interakcje użytkownika i wyświetlają dane na ekranie */
        public HomeViewModel HomeVM { get; set; }
        public UOP_CalculatorViewModel UOP_View { get; set; }
        public B2B_CalculatorViewModel B2B_View { get; set; }
        public IT_comparerViewModel IT_comparerView { get; set; }

        private object _currentView;

        /* funkcja zmienia nam to co widzimy na ekranie aplikacji gdy wybierzemy inny button */
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyCHanged();
            }
        }

        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            UOP_View = new UOP_CalculatorViewModel();
            B2B_View = new B2B_CalculatorViewModel();
            IT_comparerView = new IT_comparerViewModel();

            CurrentView = HomeVM; /* przy starcie aplikacji jest to zawsze wyświetlane i sprawia że widzimy content z pliku homeview.xaml */

            /* te komendy pozwalaja na zmiane tego co widzimy po kliknieciu w dany button */
            HomeViewCommand = new RelayCommand(o => { 
                CurrentView= HomeVM;
            });

            UOP_CalculatorViewCommand = new RelayCommand(o => {
                CurrentView = UOP_View;
            });

            B2B_CalculatorViewCommand = new RelayCommand(o => {
                CurrentView = B2B_View;
            });

            IT_comparerViewCommand = new RelayCommand(o => {
                CurrentView = IT_comparerView;
            });
        }
    }
}

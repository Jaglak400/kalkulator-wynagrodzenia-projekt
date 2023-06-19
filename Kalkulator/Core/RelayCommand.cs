using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kalkulator.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> _execute; /* przechowuje metodę która ma być wywołana */
        private Func<object, bool> _canExecute; /* określa czy polecenie może być wywołane */

        public event EventHandler CanExecuteChanged
        {
            /* Bazując na informacjach te linie kodu subskrybują lub usuwają subskrybcje dla zdarzenia które zostało wywołane */
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /* wywołuje metody w odpowiedzi na zdarzenia UI */
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /* funkcja sprawdza czy _canExecute jest null lub czy parametr zwróci wartość true */
        public bool CanExecute(object parameter) 
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /* wykonuje akcje która jest przekeazna do parametru _exectue*/
        public void Execute(object parameter) 
        { 
            _execute(parameter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Kalkulator
{
    /* 
      INotifyPropertyChanged umożliwia powiadamianie widoków o zmianach w właściwościach obiektu w architekturze Model-View-ViewModel
     */
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyCHanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); /* Sprawdza czy event jest null */
        }
    }
}

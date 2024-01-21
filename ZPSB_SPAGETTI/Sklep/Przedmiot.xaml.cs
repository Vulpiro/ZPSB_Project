using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ZPSB_SPAGETTI.Sklep
{
    /// <summary>
    /// Logika interakcji dla klasy Przedmiot.xaml
    /// </summary>
    public partial class Przedmiot : UserControl, INotifyPropertyChanged
    {
        public Przedmiot()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string nazwa;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nazwa
        {
            get { return nazwa; }
            set
            {
                nazwa = value;
                OnPropertyChanged();
            }
        }

        private string cena;

        public string Cena
        {
            get { return cena; }
            set
            {
                cena = value;
                OnPropertyChanged();
            }
        }


        private void OnPropertyChanged( [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

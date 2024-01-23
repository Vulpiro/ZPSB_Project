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
    /// Interaction logic for PostacPodglad.xaml
    /// </summary>
    public partial class PostacPodglad : UserControl, INotifyPropertyChanged
    {
        public PostacPodglad()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string sciezka;

        public string Sciezka
        {
            get { return sciezka; }
            set
            {
                sciezka = value;
                OnPropertyChanged();
            }
        }

        private string imie;

        public string Imie
        {
            get { return imie; }
            set
            {
                imie = value;
                OnPropertyChanged();
            }
        }

        private string xp;

        public string XP
        {
            get { return xp; }
            set
            {
                xp = value;
                OnPropertyChanged();
            }
        }

        private string gp;

        public string GP
        {
            get { return gp; }
            set
            {
                gp = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

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
using ZPSB_SPAGETTI.View.Pages; // Dodaje lokacje plików

namespace ZPSB_SPAGETTI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Funkcja przycisków gdy je klikniesz
        private void HabitBtnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new HabitPage(); //Ustawiam by frame otrzymywał konent w postaci wybranej strony przy kliknieciu
        }
        private void GameBtnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new GamePage();
        }

        private void HeroBtnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new HeroPage();
        }
    }
}

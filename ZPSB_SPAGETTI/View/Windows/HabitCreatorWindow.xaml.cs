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
using System.Windows.Shapes;
using ZPSB_SPAGETTI.Habit;

namespace ZPSB_SPAGETTI.View.Windows
{
    /// <summary>
    /// Interaction logic for HabitCreatorWindow.xaml
    /// </summary>
    public partial class HabitCreatorWindow : Window
    {
        public HabitCreatorWindow()
        {
            InitializeComponent();
        }

        private void BtnConfirmClick(object sender, RoutedEventArgs e)
        {
            HabitHandler hh = HabitHandler.GetInstance(); // w taki sposób "tworzymy" obiekt który jest singletonem
            hh.CreateNewHabit(TBName.Text, TBDescription.Text, new DateTime());
            Close();
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

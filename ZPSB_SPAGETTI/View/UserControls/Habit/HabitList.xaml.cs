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
using ZPSB_SPAGETTI.Habit;
using ZPSB_SPAGETTI.View.Windows;

namespace ZPSB_SPAGETTI.View.UserControls.Habit
{
    /// <summary>
    /// Logika interakcji dla klasy HabitList.xaml
    /// </summary>
    public partial class HabitList : UserControl
    {
        public HabitList()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            HabitCreatorWindow hcw = new HabitCreatorWindow();
            hcw.Show();
        }
    }
}

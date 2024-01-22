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

namespace ZPSB_SPAGETTI.View.UserControls.Habit
{
    /// <summary>
    /// Interaction logic for HabitScrollList.xaml
    /// </summary>
    public partial class HabitScrollList : UserControl
    {
        public HabitScrollList()
        {
            InitializeComponent();
            HabitHandler hh = HabitHandler.GetInstance();
            HabitScrollListLV.ItemsSource = hh.habitObjList;
        }
    }
}

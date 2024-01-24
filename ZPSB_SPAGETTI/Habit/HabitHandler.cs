using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSB_SPAGETTI.Habit
{
    //Robimy z tego singleton żeby nie było więcej instancji tego handlera
    sealed class HabitHandler
    {
        private HabitHandler()
        {

        }

        private static HabitHandler _instance;

        public static HabitHandler GetInstance()
        {
            if(_instance == null)
            {
                _instance = new HabitHandler();
            }
            return _instance;
        }

        public List<HabitObj> habitObjList = new List<HabitObj>();

        public void AddNewHabit(HabitObj newHabit)
        {
            habitObjList.Add(newHabit);
        }

        public void CreateNewHabit(string name, string description, DateTime time)
        {
            AddNewHabit(new HabitObj(name, description, time));
        }

        public void CheckHabitTime()
        {

        }

        public void EditHabit(int selectedHabit)
        {

        }

        public void DeleteHabit(int selectedHabit)
        {

        }

        public HabitObj GetHabit(int selectedHabit)
        {
            return habitObjList[selectedHabit];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSB_SPAGETTI.Habit
{
    class HabitCreator
    {
        //It is to be changed
        public HabitObj CreateHabit(string name, string description, DateTime time, int damage)
        {
            return new HabitObj(name, description, time, damage);
        }
    }
}

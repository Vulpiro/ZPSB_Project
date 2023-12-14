using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSB_SPAGETTI.Habit
{
    class HabitObj
    {
        #region variables
        //Fields
        private string name;
        private string description;
        private DateTime habitTime;
        private int damage;
        //Properties
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime HabitTime 
        {
            get { return habitTime; }
            set { habitTime = value; }
        }
        public int Damage 
        { 
            get { return damage; } 
            set { damage = value; } 
        }
        #endregion

        public HabitObj(string name, string description, DateTime time, int damage)
        {
            Name = name;
            Description = description;
            HabitTime = time;
            Damage = damage;
        }
    }
}

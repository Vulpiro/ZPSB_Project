using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPSB_SPAGETTI.Game.Items;

namespace ZPSB_SPAGETTI.Inventory
{
    //Singleton
    sealed class InventoryHandler
    {
        private InventoryHandler()
        {

        }

        private static InventoryHandler _instance;

        public static InventoryHandler GetInstance()
        {
            if(_instance == null)
            {
                _instance = new InventoryHandler();
            }
            return _instance;
        }

        public List<Item> inventorylist = new List<Item>();

        public void AddNewItem(Item newitem)
        {
            inventorylist.Add(newitem);
        }

        public void DeleteItem(int selectedItem)
        {

        }
    }
}

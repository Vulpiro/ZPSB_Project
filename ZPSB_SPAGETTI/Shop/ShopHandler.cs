using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSB_SPAGETTI.Shop
{
    //Singleton
    sealed class ShopHandler
    {
        private ShopHandler()
        {

        }

        private static ShopHandler _instance;

        public static ShopHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ShopHandler();
            }
            return _instance;
        }

        public List<ShopItem> shopItemList = new List<ShopItem>();

        public void BuyItem()
        {

        }
    }
}

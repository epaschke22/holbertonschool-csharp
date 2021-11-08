using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        public Inventory(string user_id = "0", string item_id = "0", int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 1)
                quantity = 1;
            this.quantity = quantity;
        }
    }
}

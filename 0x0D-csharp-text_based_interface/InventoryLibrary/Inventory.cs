using System;

namespace InventoryLibrary
{
    ///<summary>Inventory Class</summary>
    public class Inventory : BaseClass
    {
        ///<summary>user_id</summary>
        public string user_id {get; set;}
        ///<summary>item_id</summary>
        public string item_id {get; set;}
        ///<summary>quantity</summary>
        public int quantity {get; set;}

        ///<summary>Constructor</summary>
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

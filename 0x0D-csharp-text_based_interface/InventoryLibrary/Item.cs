using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    ///<summary>Item Class</summary>
    public class Item : BaseClass
    {
        ///<summary>name</summary>
        public string name;
        ///<summary>description</summary>
        public string description;
        ///<summary>price</summary>
        public float price;
        //List<string> tags = new List<string>();

        ///<summary>Constructor</summary>
        public Item(string name = "", string description = "", float price = 0.00f)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price * 100f) / 100f;
        }
    }
}

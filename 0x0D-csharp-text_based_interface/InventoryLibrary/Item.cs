using System;
using System.Collections.Generic;
using System.Collections;

namespace InventoryLibrary
{
    ///<summary>Item Class</summary>
    public class Item : BaseClass
    {
        ///<summary>name</summary>
        public string name {get; set;}
        ///<summary>description</summary>
        public string description {get; set;}
        ///<summary>price</summary>
        public float price {get; set;}
        //List<string> tags = new List<string>();

        ///<summary>Constructor</summary>
        public Item(string name = "deault_item", string description = "", float price = 0.00f)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price * 100f) / 100f;
        }
    }
}

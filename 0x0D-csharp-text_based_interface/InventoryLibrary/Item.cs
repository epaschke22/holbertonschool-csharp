using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        string name = "Item";
        string description;
        float price;
        List<string> tags = new List<string>();
    }
}

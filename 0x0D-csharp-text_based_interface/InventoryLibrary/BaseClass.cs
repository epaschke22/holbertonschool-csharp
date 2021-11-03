using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        public string id = Guid.NewGuid().ToString();
        DateTime date_created = DateTime.Now;
        DateTime date_updated = DateTime.Now;
    }
}

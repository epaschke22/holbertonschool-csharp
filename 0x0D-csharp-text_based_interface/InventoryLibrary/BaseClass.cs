using System;

namespace InventoryLibrary
{
    ///<summary>Base class to be inherited from</summary>
    public class BaseClass
    {
        ///<summary>id</summary>
        public string id = Guid.NewGuid().ToString();
        ///<summary>DateTime</summary>
        public DateTime date_created = DateTime.Now;
        ///<summary>DateTime</summary>
        public DateTime date_updated = DateTime.Now;
    }
}

using System;

namespace InventoryLibrary
{
    ///<summary>Base class to be inherited from</summary>
    public class BaseClass
    {
        ///<summary>id</summary>
        public string id {get; set;} = Guid.NewGuid().ToString();
        ///<summary>DateTime</summary>
        public DateTime date_created {get; set;} = DateTime.Now;
        ///<summary>DateTime</summary>
        public DateTime date_updated {get; set;} = DateTime.Now;
    }
}

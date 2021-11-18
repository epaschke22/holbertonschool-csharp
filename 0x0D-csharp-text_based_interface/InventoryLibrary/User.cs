using System;

namespace InventoryLibrary
{
    ///<summary>User Class</summary>
    public class User : BaseClass
    {
        ///<summary>name</summary>
        public string name {get; set;}

        ///<summary>Constructor</summary>
        public User(string name = "deault_user")
        {
            this.name = name;
        }
    }
}

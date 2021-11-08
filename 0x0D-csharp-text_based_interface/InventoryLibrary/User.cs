using System;

namespace InventoryLibrary
{
    ///<summary>User Class</summary>
    public class User : BaseClass
    {
        ///<summary>name</summary>
        public string name;

        ///<summary>Constructor</summary>
        public User(string name = "deault_user")
        {
            this.name = name;
        }
    }
}

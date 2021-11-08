using System;

namespace InventoryLibrary
{
    ///<summary>User Class</summary>
    public class User : BaseClass
    {
        string name;

        ///<summary>Constructor</summary>
        public User(string name = "user")
        {
            this.name = name;
        }
    }
}

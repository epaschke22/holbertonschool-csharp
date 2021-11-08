using System;

namespace InventoryLibrary
{
    ///<summary>User Class</summary>
    public class User : BaseClass
    {
        ///<summary>name</summary>
        public string name;

        ///<summary>Constructor</summary>
        public User(string name = "user")
        {
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        Dictionary<string, string> objects = new Dictionary<string, string>();

        public Dictionary<string, string> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name, obj.id);
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}

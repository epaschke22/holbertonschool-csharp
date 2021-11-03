using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        string fileName = "./storage/inventory_manager.json";
        Dictionary<string, string> objects = new Dictionary<string, string>();

        public Dictionary<string, string> All(BaseClass obj = null)
        {
            if (obj == null)
                return objects;
        }

        public void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name + '.' + obj.id, obj);
        }

        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            File.WriteAllText(fileName, jsonString);
        }

        public void Load()
        {
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
        }
    }
}

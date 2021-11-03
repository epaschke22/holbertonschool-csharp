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
        static Dictionary<string, string> objects = new Dictionary<string, string>();

        static public Dictionary<string, string> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name + '.' + obj.id, obj.ToString());
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

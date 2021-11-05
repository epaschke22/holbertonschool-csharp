using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        static string fileName = "./storage/inventory_manager.json";
        static Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();

        public static Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        public static void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name + '.' + obj.id, obj);
        }

        public static void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            File.WriteAllText(fileName, jsonString);
        }

        public static void Load()
        {
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}

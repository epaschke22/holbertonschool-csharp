using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    ///<summary>Storage Class</summary>
    public class JSONStorage
    {
        static string fileName = "./storage/inventory_manager.json";
        ///<summary>Dictionary Database</summary>
        public static Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();

        ///<summary>returns database</summary>
        public static Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        ///<summary>Adds new item to database</summary>
        public static void New(BaseClass obj)
        {
            objects.Add(obj.GetType().Name + '.' + obj.id, obj);
        }

        ///<summary>Serializes</summary>
        public static void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(fileName, jsonString);
        }

        ///<summary>Deserializes</summary>
        public static void Load()
        {
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}

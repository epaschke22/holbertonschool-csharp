using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    ///<summary>Main App</summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<classNames> show all ClassNames of objects");
            Console.WriteLine("<all> show all objects");
            Console.WriteLine("<all [ClassName]> show all objects of a ClassNam");
            Console.WriteLine("<create [ClassName]> a new object");
            Console.WriteLine("<create Inventory (item ID) (user ID)> make a new Inventory object");
            Console.WriteLine("<show [ClassName] [object_id]> an object");
            Console.WriteLine("<update [ClassName] [object_id]> an object");
            Console.WriteLine("<delete [ClassName] [object_id]> an object");
            Console.WriteLine("<exit>");

            //JSONStorage.Load();
            while (true)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(' ');
                manageInputs(commands);
            }
        }

        public static void manageInputs(string[] commands)
        {
            string[] classNames = { "Item", "User", "Inventory" };
            if (commands.Length > 1 && !classNames.Contains<string>(commands[1]))
            {
                Console.WriteLine($"{commands[1]} is not a valid object type");
                return;
            }

            switch(commands[0])
            {
                case "classNames":
                    Dictionary<string, BaseClass> currentDB = new Dictionary<string, BaseClass>();
                    currentDB = JSONStorage.All();
                    List<string> existingClassNames = new List<string>();
                    foreach (var entry in currentDB)
                    {
                        string[] objectname = entry.Key.Split('.');
                        if (!(existingClassNames.Contains(objectname[0])))
                            existingClassNames.Add(objectname[0]);
                    }
                    if (existingClassNames.Count > 0)
                    {
                        Console.Write("Classes in Database: ");
                        foreach (string clsName in existingClassNames)
                            Console.Write($"{clsName} ");
                        Console.WriteLine("");
                    }
                    else
                        Console.WriteLine("No Objects Database");
                    break;
                case "all":
                    Dictionary<string, BaseClass> result = new Dictionary<string, BaseClass>();
                    if (commands.Length == 1)
                        result = JSONStorage.All();
                    else
                        result = AllClassName(commands[1]);
                    foreach (KeyValuePair<string, BaseClass> entry in result)
                    {
                        string key = entry.Key;
                        string value = entry.Value.ToString();
                        Console.WriteLine($"{key},{value}");
                    }
                    break;
                case "create":
                    if (commands.Length == 1)
                        Console.WriteLine("Useage: <Create [ClassName]>");
                    switch(commands[1])
                    {
                        case "Item":
                            Item itemObj = new Item();
                            JSONStorage.New(itemObj);
                            Console.WriteLine($"Created Item {itemObj.id}");
                            break;
                        case "User":
                            User userObj = new User();
                            JSONStorage.New(userObj);
                            Console.WriteLine($"Created User {userObj.id}");
                            break;
                        case "Inventory":
                            if (commands.Length < 4)
                            {
                                Console.WriteLine($"Inventory requires user and item ID");
                                break;
                            }
                            if (GetObject("Item", commands[2]) == null)
                            {
                                Console.WriteLine($"Item doesnt exist");
                                break;
                            }
                            if (GetObject("User", commands[3]) == null)
                            {
                                Console.WriteLine($"User doesnt exist");
                                break;
                            }
                            Inventory invObj = new Inventory(commands[2], commands[3]);
                            JSONStorage.New(invObj);
                            Console.WriteLine($"Created Inventory {invObj.id}");
                            break;
                        default:
                            Console.WriteLine("Not a vaild class");
                            break;
                    }
                    break;
                case "show":
                    if (commands.Length < 3)
                        Console.WriteLine("Useage: <Show [ClassName] [object_id]>");
                    else
                    {
                        BaseClass showObj = GetObject(commands[1], commands[2]);
                        if (showObj == null)
                        {
                            Console.WriteLine($"Object doesnt exist");
                            break;
                        }
                        Console.WriteLine(showObj);
                    }
                    break;
                case "update":
                    if (commands.Length < 3)
                        Console.WriteLine("Useage: <Update [ClassName] [object_id]>");
                    else
                    {
                        BaseClass showObj = GetObject(commands[1], commands[2]);
                        if (showObj == null)
                        {
                            Console.WriteLine($"Object doesnt exist");
                            break;
                        }
                        Console.WriteLine(showObj);
                    }
                    break;
                case "delete":
                    if (commands.Length < 3)
                        Console.WriteLine("Useage: <Delete [ClassName] [object_id]>");
                    else
                    {
                        BaseClass showObj = GetObject(commands[1], commands[2]);
                        if (showObj == null)
                        {
                            Console.WriteLine($"Object doesnt exist");
                            break;
                        }
                        string objectName = commands[1] + "." + commands[2];
                        JSONStorage.objects.Remove(objectName);
                        Console.WriteLine($"{objectName} has been removed");
                    }
                    break;
                case "exit":
                    JSONStorage.Save();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine($"{commands[0]} is not a valid command");
                    break;
            }
        }

        public static Dictionary<string, BaseClass> AllClassName(string className)
        {
            Dictionary<string, BaseClass> objects = JSONStorage.All();
            Dictionary<string, BaseClass> result = new Dictionary<string, BaseClass>();
            foreach (var entry in objects)
            {
                string[] name = entry.Key.Split('.');
                if (name[0] == className)
                    result.Add(entry.Key, entry.Value);
            }
            return result;
        }

        public static BaseClass GetObject(string className, string classId)
        {
            Dictionary<string, BaseClass> objects = JSONStorage.All();
            string searchItem = className + '.' + classId;
            foreach (var entry in objects)
                if (searchItem == entry.Key)
                    return entry.Value;
            return null;
        }
    }
}

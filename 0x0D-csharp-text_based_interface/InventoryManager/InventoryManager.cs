using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassNam");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");

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
                case "All":
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
                case "Create":
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
                            Inventory invObj = new Inventory();
                            JSONStorage.New(invObj);
                            Console.WriteLine($"Created Inventory {invObj.id}");
                            break;
                        default:
                            Console.WriteLine("Not a vaild class");
                            break;
                    }
                    break;
                case "Show":
                    if (commands.Length < 2)
                        Console.WriteLine("Useage: <Show [ClassName object_id]>");
                    else
                    {
                        BaseClass showObj = GetObject(commands[1], commands[2]);
                        Console.WriteLine(showObj);
                    }
                    break;
                case "Update":
                    if (commands.Length < 2)
                        Console.WriteLine("Useage: <Update [ClassName object_id]>");
                    break;
                case "Delete":
                    if (commands.Length < 2)
                        Console.WriteLine("Useage: <Delete [ClassName object_id]>");
                    break;
                case "Exit":
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

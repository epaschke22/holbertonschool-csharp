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
                    Dictionary<string, string> result = new Dictionary<string, string>();
                    if (commands.Length == 1)
                        result = JSONStorage.All();
                    else
                        result = AllClassName(commands[1]);
                    Console.WriteLine(result);
                    break;
                case "Create":
                    break;
                case "Show":
                    break;
                case "Update":
                    break;
                case "Delete":
                    break;
                case "Exit":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine($"{commands[0]} is not a valid command");
                    break;
            }
        }

        public static Dictionary<string, string> AllClassName(string className)
        {
            Dictionary<string, string> objects = JSONStorage.All();
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (var entry in objects)
            {
                string[] name = entry.Key.Split('.');
                if (name[0] == className)
                    result.Add(entry.Key, entry.Value);
            }
            return result;
        }
    }
}

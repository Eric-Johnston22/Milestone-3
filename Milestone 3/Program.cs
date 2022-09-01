using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();

            Console.WriteLine("Adding items to inventory...\n");
            // Add 4 items to inventory
            inventoryManager.AddItem("Hiking shoe", 3, "9");
            inventoryManager.AddItem("Tent", 3, "2 person");
            inventoryManager.AddItem("Pants", 5, "Large");
            inventoryManager.AddItem("Shirt", 7, "Medium");

            // Display inventory
            inventoryManager.DisplayItems();

            Console.WriteLine("\n----------------------------------------------------------------------");

            // Await keystroke to continue
            Console.ReadKey();

            Console.WriteLine("\nEnter item index to remove from inventory: ");
            //Remove Pants from inventory
            inventoryManager.DeleteItem(int.Parse(Console.ReadLine()));

            Console.WriteLine("\n");
            // Display inventory after removing item
            inventoryManager.DisplayItems();

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            // Restock item
            Console.WriteLine("\nEnter item index and new stock amount: ");
            inventoryManager.RestockItem(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("\n");

            // Display inventory after restocking item
            inventoryManager.DisplayItems();

            Console.WriteLine("\n----------------------------------------------------------------------\n");

            // Await keystroke to continue
            Console.ReadKey();

            Console.WriteLine("\nSearch inventory for an item, by name, quantity or both: ");
            inventoryManager.ItemSearch(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine("\n");

            // Await keystroke to continue
            Console.ReadKey();
        }
    }
}

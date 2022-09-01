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

        // Item class
        public class Item
        {
            public string itemName;
            public int qty;
            public string size;

            // Constructor with parameters
            public Item(string itemName, int qty, string size)
            {
                this.itemName = itemName;
                this.qty = qty;
                this.size = size;
            }
        }

        class InventoryManager
        {
            // items array, will hold 50 arbitrarily
            public static Item[] items = new Item[50];
            public static int itemLength = 50;
            public static int currentItems = 0;

            public void DisplayItems()
            {
                for (int i = 0; i < currentItems; i++)
                {
                    Console.WriteLine(items[i].itemName + " " + items[i].qty);
                }
            }

            public void AddItem(string itemName, int qty, string size)
            {
                items[currentItems] = new Item(itemName, qty, size);
                currentItems ++;
            }

            public void DeleteItem(int index)
            {
                for (int i = index; i < currentItems; i++)
                {
                    items[i] = items[i + 1];
                }
                currentItems --;
            }

            public void RestockItem(int index, int qty)
            {
                for (int i = index; i < currentItems; i++)
                {
                    items[index].qty = qty;
                }
                
            }

            public void ItemSearch(string name, int qty)
            {
                for (int i = 0; i < currentItems; i++)
                {
                    if (items[i].itemName == name)
                    {
                        Console.WriteLine("Found item by name: " + items[i].itemName + " | Qty: " + items[i].qty);
                    }
                    if (items[i].qty == qty)
                    {
                        Console.WriteLine("Found item by quantity: " + items[i].itemName + " | Qty: " + items[i].qty);
                    }
                }
            }
        }
    }
}

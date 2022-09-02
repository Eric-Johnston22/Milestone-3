using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    class InventoryManager
    {
        // items array
        public static Item[] items = new Item[50];
        public static int currentItems = 0;

        // Display items method
        public void DisplayItems()
        {
            for (int i = 0; i < currentItems; i++)
            {
                Console.WriteLine(items[i].itemName + " " + items[i].qty);
            }
        }

        // Add item methods
        public void AddItem(string itemName, int qty, string size)
        {
            items[currentItems] = new Item(itemName, qty, size);
            currentItems++;
        }

        // Delete item method
        public void DeleteItem(int index)
        {
            for (int i = index; i < currentItems; i++)
            {
                items[i] = items[i + 1];
            }
            currentItems--;
        }

        // Restock item method
        public void RestockItem(int index, int qty)
        {
            for (int i = index; i < currentItems; i++)
            {
                items[index].qty = qty;
            }

        }

        // Item search method
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

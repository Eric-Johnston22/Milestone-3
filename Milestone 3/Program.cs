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
            inventoryManager.AddItem("Hiking shoe", 3, "shoe", 9);
            inventoryManager.AddItem("Tent", 3, "3 season", 2);
            inventoryManager.AddItem("Pants", 5, "pants", 3);
            inventoryManager.AddItem("Shirt", 7, "shirt", 7);

            // Display inventory
            inventoryManager.DisplayItems();

            Console.WriteLine("----------------------------------------------------------------------");

            // Await keystroke to continue
            Console.ReadKey();

            Console.WriteLine("\nType item name to remove from inventory: \n");
            //Remove Pants from inventory
            inventoryManager.DeleteItem(Console.ReadLine());

            // Display inventory after removing item
            inventoryManager.DisplayItems();

            Console.WriteLine("----------------------------------------------------------------------");

            // Restock item
            Console.WriteLine("\nEnter an item name and new stock amount: ");
            inventoryManager.RestockItem(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("\n");

            // Display inventory after restocking item
            inventoryManager.DisplayItems();

            Console.WriteLine("----------------------------------------------------------------------");

            // Await keystroke to continue
            Console.ReadKey();

            Console.WriteLine("\nSearch inventory for an item, by name, quantity or both: ");
            inventoryManager.ItemSearch(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("\n");

            // Await keystroke to continue
            Console.ReadKey();
        }

        public static List<Item> ItemList = new List<Item>();

        // Parent item class
        abstract public class Item
        {
            public string itemName;
            public int qty;

            // Return item type
            public abstract string getType();

            // Constructor with parameters
            public Item(string itemName, int qty)
            {
                this.itemName = itemName;
                this.qty = qty;
            }

            public string DisplayName
            {
                get
                {
                    return itemName;
                }
            }
        }

        class Footwear : Item
        {
            public string type;
            public double size;


            // Constructor with parameters
            public Footwear(string itemName, int qty, string type, double size) : base(itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        class Softgoods : Item
        {
            public string type;
            public string size;

            // Constructor with parameters
            public Softgoods(string itemName, int qty, string type, string size) : base(itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        class Hardgoods : Item
        {
            public string type;
            public double size;

            // Constructor with parameters
            public Hardgoods(string itemName, int qty, string type, double size) : base(itemName, qty)
            {
                this.type = type;
                this.size = size;
            }

            // Return item type
            public override string getType()
            {
                return type;
            }
        }

        class InventoryManager
        {
            public void DisplayItems()
            {
                for (int i = 0; i < ItemList.Count; i++)
                {
                    Console.WriteLine(ItemList[i].itemName + " | Qty: " + ItemList[i].qty);
                }
            }

            public void AddItem(string itemName, int qty, string type, double size)
            {
                ItemList.Add(new Footwear(itemName, qty, type, size));
            }

            public void DeleteItem(string name)
            {
                for (int i = 0; i < ItemList.Count; i++)
                {
                    if (ItemList[i].itemName == name)
                    {
                        ItemList.Remove(ItemList[i]);
                    }
                }
            }

            public void RestockItem(string name, int qty)
            {
                for (int i = 0; i < ItemList.Count; i++)
                {
                    if (ItemList[i].itemName == name)
                    {
                        ItemList[i].qty = qty;
                    }
                }
            }

            public void ItemSearch(string name, int qty)
            {
                for (int i = 0; i < ItemList.Count; i++)
                {
                    if (ItemList[i].itemName == name)
                    {
                        Console.WriteLine("Found item by name: " + ItemList[i].itemName + " | Qty: " + ItemList[i].qty);
                    }
                    if (ItemList[i].qty == qty)
                    {
                        Console.WriteLine("Found item by quantity: " + ItemList[i].itemName + " | Qty: " + ItemList[i].qty);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
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
}

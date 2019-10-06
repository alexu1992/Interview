using System.Collections.Generic;

namespace ConsoleApp3
{
    public class SalesTaxCalculator
    {

        public static ReceiptDetails Process(Item item1, Item item2, Item item3)
        {
            return new ReceiptDetails(new List<Item>() { item1, item2, item3 });
        }

        public static ReceiptDetails Process(Item item1, Item item2)
        {
            return new ReceiptDetails(new List<Item>() { item1, item2 });
        }

        public static ReceiptDetails Process(Item item1, Item item2, Item item3, Item item4)
        {
            return new ReceiptDetails(new List<Item>() { item1, item2, item3, item4 });
        }
    }
}

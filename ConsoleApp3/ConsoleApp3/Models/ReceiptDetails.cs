using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class ReceiptDetails
    {
        public ReceiptDetails(List<Item> items)
        {
            ReceiptItems = items;
            SalesTax = Math.Round(items.Sum(x => x.SalesTax), 2);
            Total = Math.Round(items.Sum(x => x.PriceIncludingSalesTaxNotRounded), 2);
        }

        public List<Item> ReceiptItems { get; }

        public decimal SalesTax { get; }

        public decimal Total { get; }
    }
}

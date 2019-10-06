using ConsoleApp3.Helper;
using System;

namespace ConsoleApp3
{
    public class Item
    {
        public readonly decimal PriceIncludingSalesTaxNotRounded;
        public readonly decimal SalesTax;
        public readonly decimal PriceIncludingSalesTax;

        private readonly string Name;
        private readonly decimal Price;
        private readonly Category Category;
        private readonly bool Imported;

        public Item(string name, decimal price) : this(name, price, Category.Other) { }

        public Item(string name, decimal price, bool imported) : this(name, price, Category.Other, imported) { }

        public Item(string name, decimal price, Category category) : this(name, price, category, false) { }

        public Item(string name, decimal price, Category category, bool imported)
        {
            Name = name;
            Price = price;
            Category = category;
            Imported = imported;
            PriceIncludingSalesTaxNotRounded = price
                + (category == Category.Other ? price * Tax.Sales / 100 : Tax.Non)
                + (imported ? price / Tax.Imported : Tax.Non);
            SalesTax = Math.Round(PriceIncludingSalesTaxNotRounded - Price, 2);
            PriceIncludingSalesTax = Math.Round(PriceIncludingSalesTaxNotRounded, 2);
        }
    }
}

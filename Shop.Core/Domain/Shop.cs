using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public enum ShopType
    {
        FoodShop,CarShop,
    }
    public class Shop
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public int ShopXP { get; set; }
        public int ShopXPNextLevel { get; set; }
        public int ShopLevel { get; set; }
        public ShopType ShopType { get; set; }

    }
}

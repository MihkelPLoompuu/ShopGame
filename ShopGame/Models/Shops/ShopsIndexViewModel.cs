namespace ShopGame.Models.Shops
{
    public enum ShopType
    {
        FoodShop, CarShop,
    }
    public class ShopsIndexViewModel
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public int ShopXP { get; set; }
        public int ShopXPNextLevel { get; set; }
        public int ShopLevel { get; set; }
        public ShopType ShopType { get; set; }

    }
}

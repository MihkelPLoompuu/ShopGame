using Microsoft.AspNetCore.Mvc;
using Shop.ApplicationServices.Services;
using Shop.Data;
using ShopGame.Models.Shops;

namespace ShopGame.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopContext _context;
        private readonly IShopServices _ShopServices;
        public ShopController(ShopContext context, IShopServices ShopServices)
        {
            _context = context;
            _ShopServices = ShopServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var resultingInventory = _context.Shop
                .OrderByDescending(y => y.ShopLevel)
                .Select(x => new ShopsIndexViewModel
                {
                    Id = x.Id,
                    ShopName = x.ShopName,
                    ShopType = (ShopType)x.ShopType,
                    ShopLevel = x.ShopLevel,
                });
            return View();
        }
    }
}

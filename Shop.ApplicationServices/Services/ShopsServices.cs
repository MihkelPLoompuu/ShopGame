using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
    public class ShopsServices : IShopServices
    {
        private readonly ShopContext _context;

        public ShopsServices(ShopContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get Details for one Shop
        /// </summary>
        /// <param name="id">Id of to show details</param>
        /// <returns>resulting Shop</returns>
        public async Task<Shop> DetailsAsync(Guid id)
        {
            var result = await _context.Shop
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}

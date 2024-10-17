using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Serviceinterface
{
    internal interface IShopServices
    {
        Task<Shop> DetailsAsync(Guid id);
    }
}

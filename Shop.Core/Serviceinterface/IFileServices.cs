using Shop.Core.Domain;
using Shop.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Serviceinterface
{
    public interface IFileServices
    {
        void UploadFilesToDatabase(ShopDto dto, Shop domain);
        void UploadFilesToDatavbse(ShopDto dto, Shop domain);
    }
}

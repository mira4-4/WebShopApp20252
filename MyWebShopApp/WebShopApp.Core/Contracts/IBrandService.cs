using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Contracts
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int brandId);
        List<Product> GetProductsByBrand(int brandId);
    }
}

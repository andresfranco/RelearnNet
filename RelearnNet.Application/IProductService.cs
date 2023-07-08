using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Application
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product CreateProduct(Product product);
    }
}

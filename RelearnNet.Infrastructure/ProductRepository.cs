using RelearnNet.Application;
using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Infrastructure
{
    public class ProductRepository :BaseRepository<Product>, IProductRepository

    {
        private RelearnNetDbContext _productDbContext;
        public ProductRepository(RelearnNetDbContext productDbContext):base(productDbContext)
        {
            _productDbContext = productDbContext;
        }
     
     
        public Product CreateProduct(Product product)
        {
            base.Create(product);
            return product;
        }

        public List<Product> GetAllProducts()
        {
         return base.GetAll().ToList();

        }
    }
}

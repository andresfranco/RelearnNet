using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Application
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
    {
            _productRepository = productRepository;
        }

        public Product CreateProduct(Product product)
        {
           _productRepository.CreateProduct(product);
            return product;
        }

        public List<Product> GetAllProducts()
    {
            return _productRepository.GetAllProducts();
        }

        
    }
}

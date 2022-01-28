using SampleClearArchictecture.Application.InputModels;
using SampleClearArchictecture.Application.ViewModels;
using SampleClearArchictecture.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClearArchictecture.Application.Services
{
    public class ProductService: IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModel)
        { 
        
        }
        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return new ProductViewModel(product.Title, product.Price);
        }
    }
}

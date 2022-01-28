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
    public interface IProductService
    {


        public void Add(ProductInputModel productInputModel);

        public ProductViewModel GetById(int id);
        
        
        
    }
}

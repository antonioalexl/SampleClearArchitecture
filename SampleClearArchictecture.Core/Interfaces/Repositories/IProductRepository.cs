using SampleClearArchictecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClearArchictecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        public Product GetById(int id);
        public void Add(IProductRepository product);
    }
}

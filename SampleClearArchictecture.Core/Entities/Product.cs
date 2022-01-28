using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClearArchictecture.Core.Entities
{
    public class Product
    {
        public string Title { get; set; }   
        public string Description { get; set; } 
        public decimal Price { get; set; }
        public DateTime CreateAt { get; set; }

        public bool Active { get; set; }
    }
}

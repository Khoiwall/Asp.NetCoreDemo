using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}

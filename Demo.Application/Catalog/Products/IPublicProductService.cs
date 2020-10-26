using Demo.Application.Catalog.Products.Dtos;
using Demo.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}

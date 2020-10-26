using Demo.Application.Catalog.Products.Dtos;
using Demo.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(UpdateProductEditRequest request);

        Task<int> Delete(int ProductID);

        Task<List<ProductViewModel>> GetAll();
        Task<PageViewModel<ProductViewModel>> GetAllPaing(string keyword, int pageIndex, int pageSize);
    }
}

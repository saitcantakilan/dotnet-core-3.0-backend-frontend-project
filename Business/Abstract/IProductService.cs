using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GeList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);

        IResult Add(Product model);
        IResult Delete(Product model);
        IResult Update(Product model);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concreate;

namespace Business.Abstract
{
    //iş katmanında repository kullanılmaz
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        Product GetById(int productId);
    }
}

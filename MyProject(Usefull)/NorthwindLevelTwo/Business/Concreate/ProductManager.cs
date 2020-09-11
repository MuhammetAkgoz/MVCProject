using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;

namespace Business.Concreate
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(task=>task.CategoryId==categoryId);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(task => task.ProductId == productId);
        }
    }
}

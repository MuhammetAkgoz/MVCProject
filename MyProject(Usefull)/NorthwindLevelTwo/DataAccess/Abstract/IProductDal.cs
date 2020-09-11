using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcess.Abstract;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Repository Pattern 
        
    }
}

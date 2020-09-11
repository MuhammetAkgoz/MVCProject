using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAcess.Concreate.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contexts;
using Entities.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCategoryDal:EfEntityRepository<Category,NorthwindContext>,ICategoryDal
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}

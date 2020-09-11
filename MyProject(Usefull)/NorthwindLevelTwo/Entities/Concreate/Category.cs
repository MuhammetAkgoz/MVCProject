using System;
using System.Collections.Generic;
using System.Text;
using Core.Entites.Abstract;

namespace Entities.Concreate
{
    //classlar çıplak kalmamılıdr
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
